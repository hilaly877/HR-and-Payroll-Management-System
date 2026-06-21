using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class AttendanceManagementForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        public AttendanceManagementForm()
        {
            InitializeComponent();
        }

        private void AttendanceManagementForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            SetupAttendanceGrid();
            // Default date to today
            dateTimeAttendance.Value = DateTime.Today;
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
                    
                    cmbDepartment.DataSource = dt;
                    cmbDepartment.DisplayMember = "DepartmentName";
                    cmbDepartment.ValueMember = "DepartmentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }

        private void SetupAttendanceGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            // Employee ID Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeID",
                HeaderText = "Emp ID",
                DataPropertyName = "EmployeeID",
                ReadOnly = true,
                Width = 70
            });

            // Full Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Employee Name",
                DataPropertyName = "FullName",
                ReadOnly = true,
                Width = 250
            });

            // Status Column (ComboBox)
            DataGridViewComboBoxColumn colStatus = new DataGridViewComboBoxColumn();
            colStatus.Name = "Status";
            colStatus.HeaderText = "Attendance Status";
            colStatus.Items.AddRange("Present", "Absent", "Late", "On Leave");
            colStatus.Width = 150;
            dataGridView1.Columns.Add(colStatus);
            
            // Hidden column for existing AttendanceID (if any)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AttendanceID",
                DataPropertyName = "AttendanceID",
                Visible = false
            });

            // Listen for changes to highlight the Save button
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSaveAttendance.BackColor = Color.Orange;
                btnSaveAttendance.Text = "Save Attendance *";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedValue == null) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // This query gets all employees in the department and their attendance for the selected date (if it exists)
                    string query = @"SELECT e.EmployeeID, e.FullName, a.Status, a.AttendanceID 
                                   FROM Employees e 
                                   LEFT JOIN Attendance a ON e.EmployeeID = a.EmployeeID AND a.AttendanceDate = @date 
                                   WHERE e.DepartmentID = @deptId AND e.Status = 'Active'";
                    
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", dateTimeAttendance.Value.Date);
                    cmd.Parameters.AddWithValue("@deptId", cmbDepartment.SelectedValue);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Set default status to 'Present' for new records
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Status"].Value == null || row.Cells["Status"].Value == DBNull.Value)
                        {
                            row.Cells["Status"].Value = "Present";
                        }
                    }

                    // Reset save button state
                    btnSaveAttendance.BackColor = Color.Green;
                    btnSaveAttendance.Text = "Save Attendance";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message);
            }
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e) // Consolidated Save (Mark/Update) Attendance
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please load employees first using the 'Load' button.");
                return;
            }

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
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow) continue;

                                int empId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                                string status = row.Cells["Status"].Value?.ToString() ?? "Present";
                                object attendanceId = row.Cells["AttendanceID"].Value;

                                MySqlCommand cmd = new MySqlCommand();
                                cmd.Connection = conn;
                                cmd.Transaction = trans;

                                if (attendanceId == null || attendanceId == DBNull.Value)
                                {
                                    // 1. INSERT new attendance
                                    cmd.CommandText = "INSERT INTO Attendance (EmployeeID, AttendanceDate, Status) VALUES (@empId, @date, @status)";
                                }
                                else
                                {
                                    // 2. UPDATE existing attendance
                                    cmd.CommandText = "UPDATE Attendance SET Status = @status WHERE AttendanceID = @attId";
                                    cmd.Parameters.AddWithValue("@attId", attendanceId);
                                }

                                cmd.Parameters.AddWithValue("@empId", empId);
                                cmd.Parameters.AddWithValue("@date", dateTimeAttendance.Value.Date);
                                cmd.Parameters.AddWithValue("@status", status);

                                cmd.ExecuteNonQuery();
                                count++;
                            }

                            trans.Commit();
                            MessageBox.Show(count + " Attendance records saved successfully!");
                            
                            // Reset save button state
                            btnSaveAttendance.BackColor = Color.Green;
                            btnSaveAttendance.Text = "Save Attendance";

                            btnLoad_Click(sender, e); // Refresh the grid
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Error during saving: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            // View history for the selected employee
            if (dataGridView1.CurrentRow != null)
            {
                int empId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmployeeID"].Value);
                
                // Open the ReportViewerForm and pre-filter it
                ReportViewerForm reportForm = new ReportViewerForm();
                reportForm.Show();
                
                // Automatically load the attendance history for this employee
                reportForm.LoadReport("Attendance", empId);
            }
            else
            {
                MessageBox.Show("Please select an employee in the list first.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}

