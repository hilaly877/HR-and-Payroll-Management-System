using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class EmployeeDirectoryForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        public EmployeeDirectoryForm()
        {
            InitializeComponent();
        }

        private void EmployeeDirectoryForm_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes on form load
            LoadFilterData();
            // Load all employees by default
            LoadEmployees();
        }

        private void LoadFilterData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Load Departments
                    MySqlDataAdapter daDept = new MySqlDataAdapter("SELECT * FROM Departments", conn);
                    DataTable dtDept = new DataTable();
                    daDept.Fill(dtDept);
                    
                    // Add "All" option to Department ComboBox
                    DataRow drDept = dtDept.NewRow();
                    drDept["DepartmentID"] = 0;
                    drDept["DepartmentName"] = "-- All --";
                    dtDept.Rows.InsertAt(drDept, 0);

                    cmbDepartment.DataSource = dtDept;
                    cmbDepartment.DisplayMember = "DepartmentName";
                    cmbDepartment.ValueMember = "DepartmentID";

                    // Load Designations
                    MySqlDataAdapter daDesig = new MySqlDataAdapter("SELECT * FROM Designations", conn);
                    DataTable dtDesig = new DataTable();
                    daDesig.Fill(dtDesig);

                    // Add "All" option to Designation ComboBox
                    DataRow drDesig = dtDesig.NewRow();
                    drDesig["DesignationID"] = 0;
                    drDesig["DesignationName"] = "-- All --";
                    dtDesig.Rows.InsertAt(drDesig, 0);

                    cmbDesignation.DataSource = dtDesig;
                    cmbDesignation.DisplayMember = "DesignationName";
                    cmbDesignation.ValueMember = "DesignationID";

                    // Load Statuses
                    cmbStatus.Items.Add("-- All --");
                    cmbStatus.Items.Add("Active");
                    cmbStatus.Items.Add("Inactive");
                    cmbStatus.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading filters: " + ex.Message);
            }
        }

        private void LoadEmployees()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // SQL Query using LEFT JOIN to ensure records show even if related data is missing
                    string query = @"SELECT e.EmployeeID, e.FullName, d.DepartmentName, des.DesignationName, e.Status, e.Email, e.Phone 
                                   FROM Employees e 
                                   LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID 
                                   LEFT JOIN Designations des ON e.DesignationID = des.DesignationID 
                                   WHERE (e.FullName LIKE @search OR e.Email LIKE @search OR e.NIC LIKE @search OR CAST(e.EmployeeID AS CHAR) LIKE @search)";

                    // Add dynamic filters
                    if (cmbDepartment.SelectedIndex > 0)
                        query += " AND e.DepartmentID = @deptId";
                    
                    if (cmbDesignation.SelectedIndex > 0)
                        query += " AND e.DesignationID = @desigId";
                    
                    if (cmbStatus.SelectedIndex > 0)
                        query += " AND e.Status = @status";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                    
                    if (cmbDepartment.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@deptId", cmbDepartment.SelectedValue);
                    
                    if (cmbDesignation.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@desigId", cmbDesignation.SelectedValue);
                    
                    if (cmbStatus.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmployees.DataSource = dt;

                    // Rename columns for better readability if they exist
                    if (dgvEmployees.Columns.Contains("EmployeeID")) dgvEmployees.Columns["EmployeeID"].HeaderText = "ID";
                    if (dgvEmployees.Columns.Contains("FullName")) dgvEmployees.Columns["FullName"].HeaderText = "Full Name";
                    if (dgvEmployees.Columns.Contains("DepartmentName")) dgvEmployees.Columns["DepartmentName"].HeaderText = "Department";
                    if (dgvEmployees.Columns.Contains("DesignationName")) dgvEmployees.Columns["DesignationName"].HeaderText = "Designation";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Execute the load method which uses the search/filter values
            LoadEmployees();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Clear search and reset filters
            txtSearch.Clear();
            cmbDepartment.SelectedIndex = 0;
            cmbDesignation.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            LoadEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int empId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value ?? 0);
                string empName = dgvEmployees.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "Selected Employee";

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + empName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    DeleteEmployee(empId);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int empId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value ?? 0);
                EmployeeRegistrationForm viewForm = new EmployeeRegistrationForm(empId, true);
                viewForm.ShowDialog(); // Use ShowDialog so user finishes viewing before returning
            }
            else
            {
                MessageBox.Show("Please select an employee to view.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int empId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value ?? 0);
                EmployeeRegistrationForm editForm = new EmployeeRegistrationForm(empId, false);
                editForm.ShowDialog();
                LoadEmployees(); // Refresh list after potential edit
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void DeleteEmployee(int empId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Delete from child tables first to avoid Foreign Key errors
                            string[] childTables = { "Attendance", "LeaveBalances", "LeaveRequests", "Payroll", "Users" };
                            
                            foreach (string table in childTables)
                            {
                                string deleteQuery = $"DELETE FROM {table} WHERE EmployeeID = @id";
                                MySqlCommand cmdChild = new MySqlCommand(deleteQuery, conn, trans);
                                cmdChild.Parameters.AddWithValue("@id", empId);
                                cmdChild.ExecuteNonQuery();
                            }

                            // 2. Finally, delete from the parent Employees table
                            string empQuery = "DELETE FROM Employees WHERE EmployeeID = @id";
                            MySqlCommand cmdEmp = new MySqlCommand(empQuery, conn, trans);
                            cmdEmp.Parameters.AddWithValue("@id", empId);
                            cmdEmp.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Employee and all related records deleted successfully.");
                            LoadEmployees(); // Refresh the list
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Error during deletion process: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
            }
        }
    }
}
