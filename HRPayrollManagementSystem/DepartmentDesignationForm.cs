using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class DepartmentDesignationForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        public DepartmentDesignationForm()
        {
            InitializeComponent();
        }

        private void DepartmentDesignationForm_Load(object sender, EventArgs e)
        {
            // Initial data loading
            RefreshDepartmentGrid();
            RefreshDesignationGrid();
            LoadDepartmentComboBox();
            
            // Suggest next IDs
            GenerateNextDeptID();
            GenerateNextDesignationID();
        }

        // --- DEPARTMENT SECTION ---

        private void GenerateNextDeptID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string countQuery = "SELECT COUNT(*) FROM Departments";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    int count = Convert.ToInt32(countCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        txtDeptId.Text = "1";
                    }
                    else
                    {
                        string maxQuery = "SELECT MAX(DepartmentID) FROM Departments";
                        MySqlCommand maxCmd = new MySqlCommand(maxQuery, conn);
                        object result = maxCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            txtDeptId.Text = (Convert.ToInt32(result) + 1).ToString();
                        }
                        else { txtDeptId.Text = "1"; }
                    }
                }
            }
            catch { txtDeptId.Text = "1"; }
        }

        private void RefreshDepartmentGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Departments";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDepartment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptName.Text))
            {
                MessageBox.Show("Please enter a department name.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Departments (DepartmentName, Description) VALUES (@name, @desc)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtDeptName.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department added successfully!");
                    ClearDepartmentFields();
                    RefreshDepartmentGrid();
                    LoadDepartmentComboBox(); 
                    GenerateNextDeptID(); // Suggest next ID after adding
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Update Button for Dept
        {
            if (dgvDepartment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to update.");
                return;
            }

            int deptId = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["DepartmentID"].Value ?? 0);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Departments SET DepartmentName = @name, Description = @desc WHERE DepartmentID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtDeptName.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", deptId);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department updated successfully!");
                    RefreshDepartmentGrid();
                    LoadDepartmentComboBox();
                    GenerateNextDeptID(); // Suggest next ID after update
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating department: " + ex.Message);
            }
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to delete.");
                return;
            }

            int deptId = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["DepartmentID"].Value ?? 0);

            if (MessageBox.Show("Are you sure you want to delete this department? This will also remove all designations linked to it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        // 1. Check if ANY employee is still assigned to this Department
                        string checkEmpQuery = "SELECT COUNT(*) FROM Employees WHERE DepartmentID = @id";
                        MySqlCommand cmdCheck = new MySqlCommand(checkEmpQuery, conn);
                        cmdCheck.Parameters.AddWithValue("@id", deptId);
                        int empCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (empCount > 0)
                        {
                            MessageBox.Show($"Cannot delete. There are {empCount} employees still assigned to this department. Please move/delete them first.", "Dependency Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        // 2. Perform Cascading Delete in a Transaction
                        using (MySqlTransaction trans = conn.BeginTransaction())
                        {
                            try
                            {
                                // Delete all linked Designations first
                                string deleteDesig = "DELETE FROM Designations WHERE DepartmentID = @id";
                                MySqlCommand cmdDesig = new MySqlCommand(deleteDesig, conn, trans);
                                cmdDesig.Parameters.AddWithValue("@id", deptId);
                                cmdDesig.ExecuteNonQuery();

                                // Delete the Department
                                string deleteDept = "DELETE FROM Departments WHERE DepartmentID = @id";
                                MySqlCommand cmdDept = new MySqlCommand(deleteDept, conn, trans);
                                cmdDept.Parameters.AddWithValue("@id", deptId);
                                cmdDept.ExecuteNonQuery();

                                trans.Commit();
                                MessageBox.Show("Department and its designations deleted successfully!");
                                RefreshDepartmentGrid();
                                LoadDepartmentComboBox();
                            }
                            catch (Exception ex)
                            {
                                trans.Rollback();
                                throw new Exception("Database transaction failed: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting department: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // Clear Button for Dept
        {
            ClearDepartmentFields();
            GenerateNextDeptID();
        }

        private void ClearDepartmentFields()
        {
            txtDeptId.Clear();
            txtDeptName.Clear();
            txtDescription.Clear();
        }

        // --- DESIGNATION SECTION ---

        private void LoadDepartmentComboBox()
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
                    
                    cmbDepartmentDesignation.DataSource = dt;
                    cmbDepartmentDesignation.DisplayMember = "DepartmentName";
                    cmbDepartmentDesignation.ValueMember = "DepartmentID";
                }
            }
            catch
            {
                // Simple error handling
            }
        }

        private void GenerateNextDesignationID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string countQuery = "SELECT COUNT(*) FROM Designations";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    int count = Convert.ToInt32(countCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        txtDesignationID.Text = "1";
                    }
                    else
                    {
                        string maxQuery = "SELECT MAX(DesignationID) FROM Designations";
                        MySqlCommand maxCmd = new MySqlCommand(maxQuery, conn);
                        object result = maxCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            txtDesignationID.Text = (Convert.ToInt32(result) + 1).ToString();
                        }
                        else { txtDesignationID.Text = "1"; }
                    }
                }
            }
            catch { txtDesignationID.Text = "1"; }
        }

        private void RefreshDesignationGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT d.DesignationID, d.DesignationName, dept.DepartmentName, dept.DepartmentID 
                                   FROM Designations d 
                                   JOIN Departments dept ON d.DepartmentID = dept.DepartmentID";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDesignation.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message);
            }
        }

        private void btnAddDesignation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesignationName.Text))
            {
                MessageBox.Show("Please enter a designation name.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Designations (DesignationName, DepartmentID) VALUES (@name, @deptId)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtDesignationName.Text.Trim());
                    cmd.Parameters.AddWithValue("@deptId", cmbDepartmentDesignation.SelectedValue);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Designation added successfully!");
                    RefreshDesignationGrid();
                    GenerateNextDesignationID(); // Suggest next ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding designation: " + ex.Message);
            }
        }

        private void btnUpdateDesignation_Click(object sender, EventArgs e)
        {
            if (dgvDesignation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a designation to update.");
                return;
            }

            int desigId = Convert.ToInt32(dgvDesignation.SelectedRows[0].Cells["DesignationID"].Value ?? 0);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Designations SET DesignationName = @name, DepartmentID = @deptId WHERE DesignationID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtDesignationName.Text.Trim());
                    cmd.Parameters.AddWithValue("@deptId", cmbDepartmentDesignation.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", desigId);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Designation updated successfully!");
                    RefreshDesignationGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating designation: " + ex.Message);
            }
        }

        private void btnDeleteDesignation_Click(object sender, EventArgs e)
        {
            if (dgvDesignation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a designation to delete.");
                return;
            }

            int desigId = Convert.ToInt32(dgvDesignation.SelectedRows[0].Cells["DesignationID"].Value ?? 0);

            if (MessageBox.Show("Are you sure you want to delete this designation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        // 1. Check if ANY employee is still assigned to this Designation
                        string checkEmpQuery = "SELECT COUNT(*) FROM Employees WHERE DesignationID = @id";
                        MySqlCommand cmdCheck = new MySqlCommand(checkEmpQuery, conn);
                        cmdCheck.Parameters.AddWithValue("@id", desigId);
                        int empCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (empCount > 0)
                        {
                            MessageBox.Show($"Cannot delete. There are {empCount} employees currently assigned to this designation. Please move or delete them first.", "Dependency Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        // 2. Perform Single Table Delete (Safely)
                        string query = "DELETE FROM Designations WHERE DesignationID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", desigId);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Designation deleted successfully!");
                        RefreshDesignationGrid();
                        GenerateNextDesignationID(); // Suggest next ID
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting designation: " + ex.Message);
                }
            }
        }

        private void btnClearDesignation_Click(object sender, EventArgs e)
        {
            txtDesignationID.Clear();
            txtDesignationName.Clear();
            txtDescriptionDesignation.Clear();
            GenerateNextDesignationID();
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];
                txtDeptId.Text = row.Cells["DepartmentID"].Value.ToString();
                txtDeptName.Text = row.Cells["DepartmentName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
            }
        }

        private void dgvDesignation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDesignation.Rows[e.RowIndex];
                txtDesignationID.Text = row.Cells["DesignationID"].Value.ToString();
                txtDesignationName.Text = row.Cells["DesignationName"].Value.ToString();
                cmbDepartmentDesignation.SelectedValue = row.Cells["DepartmentID"].Value;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
