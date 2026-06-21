using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class EmployeeRegistrationForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        int selectedEmpId = 0;
        bool isViewMode = false;

        public EmployeeRegistrationForm()
        {
            InitializeComponent();
        }

        public EmployeeRegistrationForm(int empId, bool viewOnly)
        {
            InitializeComponent();
            selectedEmpId = empId;
            isViewMode = viewOnly;
        }

        private void Employee_Registration_Load(object sender, EventArgs e)
        {
            // Populate Dropdowns
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedIndex = 0;

            LoadDepartments();
            LoadDesignations();
            
            if (selectedEmpId > 0)
            {
                // Loading existing employee for View or Edit
                LoadEmployeeData(selectedEmpId);
                txtEmployeeID.ReadOnly = false; // Allow manual ID entry for search

                if (isViewMode)
                {
                    DisableControls();
                    btnAdd.Visible = false;
                    btnUpdate.Visible = false;
                    this.Text = "View Employee Details";
                }
                else
                {
                    this.Text = "Edit Employee Details";
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                }
            }
            else
            {
                // New employee registration
                GenerateNextID();
                txtEmployeeID.ReadOnly = false; // Allow manual ID entry for search
                this.Text = "New Employee Registration";
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void DisableControls()
        {
            txtFullName.ReadOnly = true;
            txtNIC.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtBasicSalary.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtConfirmPassword.ReadOnly = true;
            cmbGender.Enabled = false;
            cmbStatus.Enabled = false;
            cmbDepartment.Enabled = false;
            cmbDesignation.Enabled = false;
            dtpDOB.Enabled = false;
            dtpJoiningDate.Enabled = false;
        }

        private void LoadEmployeeData(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // 1. Get Employee Info
                    string query = "SELECT * FROM Employees WHERE EmployeeID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtEmployeeID.Text = dr["EmployeeID"].ToString();
                            txtFullName.Text = dr["FullName"].ToString();
                            dtpDOB.Value = Convert.ToDateTime(dr["DateOfBirth"]);
                            cmbGender.Text = dr["Gender"].ToString();
                            txtNIC.Text = dr["NIC"].ToString();
                            txtPhone.Text = dr["Phone"].ToString();
                            txtEmail.Text = dr["Email"].ToString();
                            txtAddress.Text = dr["Address"].ToString();
                            cmbDepartment.SelectedValue = dr["DepartmentID"];
                            cmbDesignation.SelectedValue = dr["DesignationID"];
                            dtpJoiningDate.Value = Convert.ToDateTime(dr["JoiningDate"]);
                            txtBasicSalary.Text = dr["BasicSalary"].ToString();
                            cmbStatus.Text = dr["Status"].ToString();
                        }
                    }

                    // 2. Get User Info
                    string userQuery = "SELECT Username, PasswordHash FROM Users WHERE EmployeeID = @id";
                    MySqlCommand userCmd = new MySqlCommand(userQuery, conn);
                    userCmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader drUser = userCmd.ExecuteReader())
                    {
                        if (drUser.Read())
                        {
                            txtUsername.Text = drUser["Username"].ToString();
                            txtPassword.Text = drUser["PasswordHash"].ToString();
                            txtConfirmPassword.Text = drUser["PasswordHash"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
        }

        private void GenerateNextID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    
                    string countQuery = "SELECT COUNT(*) FROM Employees";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    int count = Convert.ToInt32(countCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        txtEmployeeID.Text = "1";
                    }
                    else
                    {
                        string maxQuery = "SELECT MAX(EmployeeID) FROM Employees";
                        MySqlCommand maxCmd = new MySqlCommand(maxQuery, conn);
                        object result = maxCmd.ExecuteScalar();
                        
                        if (result != null && result != DBNull.Value)
                        {
                            int maxId = Convert.ToInt32(result);
                            txtEmployeeID.Text = (maxId + 1).ToString();
                        }
                        else
                        {
                            txtEmployeeID.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating ID: " + ex.Message);
            }
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

        private void LoadDesignations()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DesignationID, DesignationName FROM Designations";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbDesignation.DataSource = dt;
                    cmbDesignation.DisplayMember = "DesignationName";
                    cmbDesignation.ValueMember = "DesignationID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Basic Validation
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text)) { MessageBox.Show("Employee ID is required."); return; }
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) { MessageBox.Show("Full Name is required."); return; }
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) { MessageBox.Show("Username is required."); return; }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) { MessageBox.Show("Password is required."); return; }
            if (txtPassword.Text != txtConfirmPassword.Text) { MessageBox.Show("Passwords do not match."); return; }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insert or Update Employee
                            string query;
                            if (selectedEmpId > 0)
                            {
                                query = @"UPDATE Employees SET FullName=@name, DateOfBirth=@dob, Gender=@gender, NIC=@nic, 
                                          Phone=@phone, Email=@email, Address=@addr, DepartmentID=@dept, DesignationID=@desig, 
                                          JoiningDate=@join, BasicSalary=@sal, Status=@status WHERE EmployeeID=@id";
                            }
                            else
                            {
                                query = @"INSERT INTO Employees (EmployeeID, FullName, DateOfBirth, Gender, NIC, Phone, Email, Address, DepartmentID, DesignationID, JoiningDate, BasicSalary, Status) 
                                          VALUES (@id, @name, @dob, @gender, @nic, @phone, @email, @addr, @dept, @desig, @join, @sal, @status)";
                            }

                            MySqlCommand empCmd = new MySqlCommand(query, conn, transaction);
                            empCmd.Parameters.AddWithValue("@id", txtEmployeeID.Text.Trim());
                            empCmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                            empCmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                            empCmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                            empCmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
                            empCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                            empCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                            empCmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                            empCmd.Parameters.AddWithValue("@dept", cmbDepartment.SelectedValue);
                            empCmd.Parameters.AddWithValue("@desig", cmbDesignation.SelectedValue);
                            empCmd.Parameters.AddWithValue("@join", dtpJoiningDate.Value.Date);
                            empCmd.Parameters.AddWithValue("@sal", decimal.Parse(string.IsNullOrEmpty(txtBasicSalary.Text) ? "0" : txtBasicSalary.Text));
                            empCmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                            empCmd.ExecuteNonQuery();

                            // 2. Create or Update User Account
                            // We check if the user exists first (Safe Update)
                            string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE EmployeeID=@id";
                            MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn, transaction);
                            checkCmd.Parameters.AddWithValue("@id", txtEmployeeID.Text.Trim());
                            int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (userExists > 0)
                            {
                                query = "UPDATE Users SET Username=@user, PasswordHash=@pass WHERE EmployeeID=@id";
                            }
                            else
                            {
                                query = "INSERT INTO Users (EmployeeID, Username, PasswordHash, Role) VALUES (@id, @user, @pass, 'Employee')";
                            }

                            MySqlCommand userCmd = new MySqlCommand(query, conn, transaction);
                            userCmd.Parameters.AddWithValue("@id", txtEmployeeID.Text.Trim());
                            userCmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                            userCmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                            userCmd.ExecuteNonQuery();

                            if (selectedEmpId == 0)
                            {
                                // 3. Initialize Leave Balances (Only for new employees)
                                string leaveQuery = "INSERT INTO LeaveBalances (EmployeeID, AnnualLeave, MedicalLeave, CasualLeave) VALUES (@id, 15, 10, 10)";
                                MySqlCommand leaveCmd = new MySqlCommand(leaveQuery, conn, transaction);
                                leaveCmd.Parameters.AddWithValue("@id", txtEmployeeID.Text.Trim());
                                leaveCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            
                            if (selectedEmpId > 0)
                            {
                                MessageBox.Show("Employee updated successfully!");
                                this.Close(); // Close the form after update
                            }
                            else
                            {
                                MessageBox.Show("Employee, account, and leave balances created successfully!");
                                ClearForm();
                            }
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on save: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtEmployeeID.Clear();
            txtFullName.Clear();
            txtNIC.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtBasicSalary.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpDOB.Value = DateTime.Today;
            dtpJoiningDate.Value = DateTime.Today;
            
            // Refresh ID for the next entry
            GenerateNextID();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Please enter an Employee ID to search.");
                return;
            }

            if (int.TryParse(txtEmployeeID.Text.Trim(), out int id))
            {
                // Loading existing employee
                LoadEmployeeData(id);
                
                // If data was found, set to Edit mode
                if (txtFullName.Text != "") 
                {
                    selectedEmpId = id;
                    isViewMode = false;
                    txtEmployeeID.ReadOnly = false; // Keep it editable for next search
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                    this.Text = "Edit Employee Details";
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Employee ID.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedEmpId = 0;
            isViewMode = false;
            txtEmployeeID.ReadOnly = false; 
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            this.Text = "New Employee Registration";
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmpId == 0)
            {
                MessageBox.Show("Please search for an employee first to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee and all their associated records (Attendance, Payroll, etc.)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlTransaction trans = conn.BeginTransaction())
                        {
                            try
                            {
                                // Cascading Deletion
                                string[] queries = {
                                    "DELETE FROM Attendance WHERE EmployeeID = @id",
                                    "DELETE FROM LeaveBalances WHERE EmployeeID = @id",
                                    "DELETE FROM LeaveRequests WHERE EmployeeID = @id",
                                    "DELETE FROM Payroll WHERE EmployeeID = @id",
                                    "DELETE FROM Users WHERE EmployeeID = @id",
                                    "DELETE FROM Employees WHERE EmployeeID = @id"
                                };

                                foreach (string q in queries)
                                {
                                    MySqlCommand cmd = new MySqlCommand(q, conn, trans);
                                    cmd.Parameters.AddWithValue("@id", selectedEmpId);
                                    cmd.ExecuteNonQuery();
                                }

                                trans.Commit();
                                MessageBox.Show("Employee and all related data deleted successfully!");
                                btnClear_Click(sender, e); // Reset form
                            }
                            catch (Exception ex)
                            {
                                trans.Rollback();
                                MessageBox.Show("Error during deletion: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
