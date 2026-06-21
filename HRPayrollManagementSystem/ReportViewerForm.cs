using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Text;

namespace HRPayrollManagementSystem
{
    public partial class ReportViewerForm : Form
    {
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";
        string selectedReport = "EmployeeList";

        public ReportViewerForm()
        {
            InitializeComponent();
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmployees();

            // Set defaults
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cmbYear.SelectedIndex = 2; // 2024
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            // Highlight first button
            button1.BackColor = Color.LightSkyBlue;
        }

        public void LoadReport(string reportType, int employeeId = 0)
        {
            selectedReport = reportType;
            
            // Set button colors
            if (reportType == "Attendance") SetButtonColor(button2);
            else if (reportType == "Leave") SetButtonColor(button3);
            else if (reportType == "Payroll") SetButtonColor(button5);
            else if (reportType == "Payslip") SetButtonColor(button6);
            else SetButtonColor(button1);

            // Set employee filter if provided
            if (employeeId > 0)
            {
                cmbEmployee.SelectedValue = employeeId;
            }

            // Generate report
            btnGenerate_Click(null, null);
        }

        private void LoadDepartments()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT DepartmentID, DepartmentName FROM Departments", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["DepartmentID"] = 0;
                    dr["DepartmentName"] = "-- All --";
                    dt.Rows.InsertAt(dr, 0);

                    cmbDepartment.DataSource = dt;
                    cmbDepartment.DisplayMember = "DepartmentName";
                    cmbDepartment.ValueMember = "DepartmentID";
                }
            }
            catch { }
        }

        private void LoadEmployees()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT EmployeeID, FullName FROM Employees", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["EmployeeID"] = 0;
                    dr["FullName"] = "-- All --";
                    dt.Rows.InsertAt(dr, 0);

                    cmbEmployee.DataSource = dt;
                    cmbEmployee.DisplayMember = "FullName";
                    cmbEmployee.ValueMember = "EmployeeID";
                }
            }
            catch { }
        }

        // Report Type Button Clicks
        private void button1_Click(object sender, EventArgs e) { selectedReport = "EmployeeList"; SetButtonColor(button1); }
        private void button2_Click(object sender, EventArgs e) { selectedReport = "Attendance"; SetButtonColor(button2); }
        private void button3_Click(object sender, EventArgs e) { selectedReport = "Leave"; SetButtonColor(button3); }
        private void button5_Click(object sender, EventArgs e) { selectedReport = "Payroll"; SetButtonColor(button5); }
        private void button6_Click(object sender, EventArgs e) { selectedReport = "Payslip"; SetButtonColor(button6); }

        private void SetButtonColor(Button activeBtn)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            activeBtn.BackColor = Color.LightSkyBlue;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    switch (selectedReport)
                    {
                        case "EmployeeList":
                            query = @"SELECT e.EmployeeID, e.FullName, des.DesignationName AS Designation, 
                                     d.DepartmentName AS Department, e.NIC, e.BasicSalary 
                                     FROM Employees e 
                                     JOIN Departments d ON e.DepartmentID = d.DepartmentID 
                                     JOIN Designations des ON e.DesignationID = des.DesignationID 
                                     WHERE 1=1";
                            if (cmbDepartment.SelectedIndex > 0)
                            {
                                query += " AND e.DepartmentID = @deptId";
                                cmd.Parameters.AddWithValue("@deptId", cmbDepartment.SelectedValue);
                            }
                            break;

                        case "Attendance":
                            query = @"SELECT e.EmployeeID, e.FullName, a.AttendanceDate, a.Status 
                                     FROM Attendance a 
                                     JOIN Employees e ON a.EmployeeID = e.EmployeeID 
                                     WHERE a.AttendanceDate BETWEEN @from AND @to";
                            cmd.Parameters.AddWithValue("@from", dtpFrom.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@to", dtpTo.Value.ToString("yyyy-MM-dd"));
                            if (cmbEmployee.SelectedIndex > 0)
                            {
                                query += " AND a.EmployeeID = @empId";
                                cmd.Parameters.AddWithValue("@empId", cmbEmployee.SelectedValue);
                            }
                            if (cmbDepartment.SelectedIndex > 0)
                            {
                                query += " AND e.DepartmentID = @deptId";
                                cmd.Parameters.AddWithValue("@deptId", cmbDepartment.SelectedValue);
                            }
                            break;

                        case "Leave":
                            query = @"SELECT e.FullName, lr.LeaveType, lr.FromDate, lr.ToDate, lr.NumberOfDays, lr.Status 
                                     FROM LeaveRequests lr 
                                     JOIN Employees e ON lr.EmployeeID = e.EmployeeID 
                                     WHERE lr.FromDate >= @from AND lr.ToDate <= @to";
                            cmd.Parameters.AddWithValue("@from", dtpFrom.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@to", dtpTo.Value.ToString("yyyy-MM-dd"));
                            if (cmbEmployee.SelectedIndex > 0)
                            {
                                query += " AND lr.EmployeeID = @empId";
                                cmd.Parameters.AddWithValue("@empId", cmbEmployee.SelectedValue);
                            }
                            break;

                        case "Payroll":
                            query = @"SELECT p.EmployeeID, e.FullName, p.PayrollMonth, p.PayrollYear, 
                                     p.BasicSalary, p.NetSalary, p.PayrollStatus 
                                     FROM Payroll p 
                                     JOIN Employees e ON p.EmployeeID = e.EmployeeID 
                                     WHERE p.PayrollMonth = @month AND p.PayrollYear = @year";
                            cmd.Parameters.AddWithValue("@month", cmbMonth.SelectedIndex + 1);
                            cmd.Parameters.AddWithValue("@year", cmbYear.Text);
                            if (cmbDepartment.SelectedIndex > 0)
                            {
                                query += " AND e.DepartmentID = @deptId";
                                cmd.Parameters.AddWithValue("@deptId", cmbDepartment.SelectedValue);
                            }
                            break;

                        case "Payslip":
                            query = @"SELECT p.*, e.FullName, d.DepartmentName, des.DesignationName 
                                     FROM Payroll p
                                     JOIN Employees e ON p.EmployeeID = e.EmployeeID
                                     JOIN Departments d ON e.DepartmentID = d.DepartmentID
                                     JOIN Designations des ON e.DesignationID = des.DesignationID
                                     WHERE p.PayrollMonth = @month AND p.PayrollYear = @year";
                            cmd.Parameters.AddWithValue("@month", cmbMonth.SelectedIndex + 1);
                            cmd.Parameters.AddWithValue("@year", cmbYear.Text);
                            if (cmbEmployee.SelectedIndex > 0)
                            {
                                query += " AND p.EmployeeID = @empId";
                                cmd.Parameters.AddWithValue("@empId", cmbEmployee.SelectedValue);
                            }
                            break;
                    }

                    cmd.CommandText = query;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDesignation.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e) // Export to CSV
        {
            if (dgvDesignation.Rows.Count == 0) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = selectedReport + "_Report.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Headers
                string[] columnNames = dgvDesignation.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText).ToArray();
                sb.AppendLine(string.Join(",", columnNames));

                // Rows
                foreach (DataGridViewRow row in dgvDesignation.Rows)
                {
                    if (row.IsNewRow) continue;
                    string[] cells = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "").ToArray();
                    sb.AppendLine(string.Join(",", cells));
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Report exported successfully!");
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e) { }

        private void grpReportPreview_Enter(object sender, EventArgs e)
        {

        }
    }
}
