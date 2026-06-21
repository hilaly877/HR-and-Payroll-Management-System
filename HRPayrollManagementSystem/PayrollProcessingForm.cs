using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRPayrollManagementSystem
{
    public partial class PayrollProcessingForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        public PayrollProcessingForm()
        {
            InitializeComponent();
        }

        private void ppf_Load(object sender, EventArgs e)
        {
            SetupPayrollGrid();

            // Populate Month ComboBox
            string[] months = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            cmbMonth.Items.AddRange(months);
            cmbMonth.Text = DateTime.Now.Month.ToString();

            // Populate Year ComboBox
            for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 1; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }
            cmbYear.Text = DateTime.Now.Year.ToString();

            // Populate Status ComboBox
            cmbPayrollStatus.Items.AddRange(new string[] { "Pending", "Processed", "Paid" });
            cmbPayrollStatus.SelectedIndex = 0;

            LoadDepartments();
        }

        private void LoadDepartments()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DepartmentID, DepartmentName FROM Departments";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add "All" option
                    DataRow dr = dt.NewRow();
                    dr["DepartmentID"] = 0;
                    dr["DepartmentName"] = "-- All Departments --";
                    dt.Rows.InsertAt(dr, 0);

                    cmbDept.DataSource = dt;
                    cmbDept.DisplayMember = "DepartmentName";
                    cmbDept.ValueMember = "DepartmentID";
                    cmbDept.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }

        private void SetupPayrollGrid()
        {
            dgvPayroll.Columns.Clear();
            dgvPayroll.AutoGenerateColumns = false;

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "EmployeeID", HeaderText = "ID", DataPropertyName = "EmployeeID", Width = 50, ReadOnly = true });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "Name", DataPropertyName = "FullName", Width = 150, ReadOnly = true });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "BasicSalary", HeaderText = "Basic", DataPropertyName = "BasicSalary", Width = 100, ReadOnly = true });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "Allowance", HeaderText = "Allow.", DataPropertyName = "Allowance", Width = 80, ReadOnly = false });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "OTAmount", HeaderText = "OT", DataPropertyName = "OTAmount", Width = 80, ReadOnly = false });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "EPF", HeaderText = "EPF(8%)", DataPropertyName = "EPF", Width = 80, ReadOnly = true });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "ETF", HeaderText = "ETF(3%)", DataPropertyName = "ETF", Width = 80, ReadOnly = true });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "Deductions", HeaderText = "Other Ded.", DataPropertyName = "OtherDeductions", Width = 80, ReadOnly = false });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "NetSalary", HeaderText = "Net Salary", DataPropertyName = "NetSalary", Width = 120, ReadOnly = true });

            dgvPayroll.ReadOnly = false;
            dgvPayroll.CellValueChanged += DgvPayroll_CellValueChanged;
        }

        private void DgvPayroll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Auto-recalculate row when values change
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPayroll.Rows[e.RowIndex];
                decimal basic = Convert.ToDecimal(row.Cells["BasicSalary"].Value ?? 0);
                decimal allowance = Convert.ToDecimal(row.Cells["Allowance"].Value ?? 0);
                decimal ot = Convert.ToDecimal(row.Cells["OTAmount"].Value ?? 0);
                decimal deductions = Convert.ToDecimal(row.Cells["Deductions"].Value ?? 0);
                
                decimal epf = basic * 0.08m;
                decimal etf = basic * 0.03m;
                decimal net = (basic + allowance + ot) - (epf + deductions);

                // Temporarily disable event to avoid recursion
                dgvPayroll.CellValueChanged -= DgvPayroll_CellValueChanged;
                row.Cells["EPF"].Value = epf;
                row.Cells["ETF"].Value = etf;
                row.Cells["NetSalary"].Value = net;
                dgvPayroll.CellValueChanged += DgvPayroll_CellValueChanged;

                CalculateTotals();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    int month = int.Parse(cmbMonth.Text);
                    int year = int.Parse(cmbYear.Text);
                    string statusFilter = cmbPayrollStatus.Text;

                    // 1. Unified Query: Always LEFT JOIN with Payroll for the selected Month/Year
                    // This ensures that if a record ALREADY exists, we see it.
                    string query = @"SELECT e.EmployeeID, e.FullName, e.BasicSalary, 
                                     p.Allowance, p.OTAmount, p.EPF, p.ETF, p.OtherDeductions, p.NetSalary 
                                     FROM Employees e 
                                     LEFT JOIN Payroll p ON e.EmployeeID = p.EmployeeID 
                                     AND p.PayrollMonth = @month AND p.PayrollYear = @year 
                                     WHERE e.Status = 'Active' ";
                    
                    // 2. Add Department Filter
                    if (cmbDept.SelectedIndex > 0)
                    {
                        query += " AND e.DepartmentID = @deptId ";
                    }

                    // 3. Add Payroll Status Filter (if not 'All' or 'Pending/Draft' that shows everyone)
                    if (cmbPayrollStatus.SelectedIndex > 0 && statusFilter != "Pending" && statusFilter != "Draft")
                    {
                        query += " AND p.PayrollStatus = @payStatus ";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);

                    if (cmbDept.SelectedIndex > 0)
                    {
                        cmd.Parameters.AddWithValue("@deptId", cmbDept.SelectedValue);
                    }
                    
                    if (cmbPayrollStatus.SelectedIndex > 0 && statusFilter != "Pending" && statusFilter != "Draft")
                    {
                        cmd.Parameters.AddWithValue("@payStatus", statusFilter);
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPayroll.DataSource = dt;

                    lblPayrollStatus.Text = "Status: Loaded";
                    lblPayrollStatus.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (dgvPayroll.Rows.Count == 0)
            {
                MessageBox.Show("Please load employees first.");
                return;
            }

            foreach (DataGridViewRow row in dgvPayroll.Rows)
            {
                if (row.IsNewRow) continue;

                decimal basic = Convert.ToDecimal(row.Cells["BasicSalary"].Value ?? 0);

                // Static values for this beginner version (In real app, fetch from Attendance/OT)
                decimal allowance = 5000;
                decimal otAmount = 0;

                // Statutory Calculations
                decimal epf = basic * 0.08m; // Employee contribution (8%)
                decimal etf = basic * 0.03m; // Just for display/saving (Employer usually pays but some systems deduct as other if configured)
                decimal deductions = 0;

                decimal netSalary = basic + allowance + otAmount - epf - deductions;

                row.Cells["Allowance"].Value = allowance;
                row.Cells["OTAmount"].Value = otAmount;
                row.Cells["EPF"].Value = epf;
                row.Cells["ETF"].Value = etf;
                row.Cells["Deductions"].Value = deductions;
                row.Cells["NetSalary"].Value = netSalary;
            }

            CalculateTotals();
            lblPayrollStatus.Text = "Status: Calculated";
            lblPayrollStatus.ForeColor = Color.Green;
        }

        private void CalculateTotals()
        {
            decimal totalBasic = 0;
            decimal totalNet = 0;

            foreach (DataGridViewRow row in dgvPayroll.Rows)
            {
                if (row.IsNewRow) continue;
                totalBasic += Convert.ToDecimal(row.Cells["BasicSalary"].Value ?? 0);
                totalNet += Convert.ToDecimal(row.Cells["NetSalary"].Value ?? 0);
            }

            lblPayrollStatus.Text = $"Total Employees: {dgvPayroll.Rows.Count} | Total Net: LKR {totalNet:N2}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvPayroll.Rows.Count == 0) return;

            int month = int.Parse(cmbMonth.Text);
            int year = int.Parse(cmbYear.Text);
            string status = cmbPayrollStatus.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            int count = 0;
                            foreach (DataGridViewRow row in dgvPayroll.Rows)
                            {
                                if (row.IsNewRow) continue;

                                int empId = Convert.ToInt32(row.Cells["EmployeeID"].Value ?? 0);
                                decimal basic = Convert.ToDecimal(row.Cells["BasicSalary"].Value ?? 0);
                                decimal allow = Convert.ToDecimal(row.Cells["Allowance"].Value ?? 0);
                                decimal ot = Convert.ToDecimal(row.Cells["OTAmount"].Value ?? 0);
                                decimal epf = Convert.ToDecimal(row.Cells["EPF"].Value ?? 0);
                                decimal etf = Convert.ToDecimal(row.Cells["ETF"].Value ?? 0);
                                decimal ded = Convert.ToDecimal(row.Cells["Deductions"].Value ?? 0);
                                decimal net = Convert.ToDecimal(row.Cells["NetSalary"].Value ?? 0);

                                // Check if record already exists
                                string checkQuery = "SELECT COUNT(*) FROM Payroll WHERE EmployeeID = @empId AND PayrollMonth = @month AND PayrollYear = @year";
                                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn, trans);
                                checkCmd.Parameters.AddWithValue("@empId", empId);
                                checkCmd.Parameters.AddWithValue("@month", month);
                                checkCmd.Parameters.AddWithValue("@year", year);
                                
                                int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                                string query;

                                if (existingCount > 0)
                                {
                                    query = @"UPDATE Payroll SET 
                                              BasicSalary = @basic, Allowance = @allow, OTAmount = @ot, 
                                              EPF = @epf, ETF = @etf, OtherDeductions = @ded, 
                                              NetSalary = @net, PayrollStatus = @status
                                              WHERE EmployeeID = @empId AND PayrollMonth = @month AND PayrollYear = @year";
                                }
                                else
                                {
                                    query = @"INSERT INTO Payroll (EmployeeID, PayrollMonth, PayrollYear, BasicSalary, Allowance, OTAmount, EPF, ETF, OtherDeductions, NetSalary, PayrollStatus) 
                                              VALUES (@empId, @month, @year, @basic, @allow, @ot, @epf, @etf, @ded, @net, @status)";
                                }
                                
                                MySqlCommand cmd = new MySqlCommand(query, conn, trans);
                                cmd.Parameters.AddWithValue("@empId", empId);
                                cmd.Parameters.AddWithValue("@month", month);
                                cmd.Parameters.AddWithValue("@year", year);
                                cmd.Parameters.AddWithValue("@basic", basic);
                                cmd.Parameters.AddWithValue("@allow", allow);
                                cmd.Parameters.AddWithValue("@ot", ot);
                                cmd.Parameters.AddWithValue("@epf", epf);
                                cmd.Parameters.AddWithValue("@etf", etf);
                                cmd.Parameters.AddWithValue("@ded", ded);
                                cmd.Parameters.AddWithValue("@net", net);
                                cmd.Parameters.AddWithValue("@status", status);

                                cmd.ExecuteNonQuery();
                                count++;
                            }

                            trans.Commit();
                            MessageBox.Show($"{count} Records Processed as '{status}' Successfully!");
                            lblPayrollStatus.Text = $"Status: {status} Processed";
                            lblPayrollStatus.ForeColor = Color.DarkGreen;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw new Exception("Transaction failed. Changes were rolled back. Error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payroll: " + ex.Message);
            }
        }

        private void btnGenerateSlip_Click(object sender, EventArgs e)
        {
            if (dgvPayroll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee row to generate payslip.");
                return;
            }

            var row = dgvPayroll.SelectedRows[0];
            decimal basic = Convert.ToDecimal(row.Cells["BasicSalary"].Value ?? 0);
            decimal epf = Convert.ToDecimal(row.Cells["EPF"].Value ?? 0);
            decimal etf = basic * 0.03m;

            string slip = $"==========================================\n" +
                          $"       PAYSLIP - {cmbMonth.Text} / {cmbYear.Text} \n" +
                          $"==========================================\n" +
                          $"Employee: {row.Cells["FullName"].Value}\n" +
                          $"ID      : {row.Cells["EmployeeID"].Value}\n" +
                          $"------------------------------------------\n" +
                          $"Basic Salary   : LKR {basic:N2}\n" +
                          $"Allowance      : LKR {row.Cells["Allowance"].Value:N2}\n" +
                          $"OT Amount      : LKR {row.Cells["OTAmount"].Value:N2}\n" +
                          $"------------------------------------------\n" +
                          $"EPF (8%)       : LKR -{epf:N2}\n" +
                          $"ETF (3%)       : LKR -{etf:N2} (Employer)\n" +
                          $"Other Deduct.  : LKR -{row.Cells["Deductions"].Value:N2}\n" +
                          $"------------------------------------------\n" +
                          $"NET SALARY     : LKR {row.Cells["NetSalary"].Value:N2}\n" +
                          $"==========================================\n" +
                          $"Status: {cmbPayrollStatus.Text}";

            MessageBox.Show(slip, "Payslip Preview");
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
