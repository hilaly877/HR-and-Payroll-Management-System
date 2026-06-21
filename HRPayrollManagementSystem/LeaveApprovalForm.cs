using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class LeaveApprovalForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        public LeaveApprovalForm()
        {
            InitializeComponent();
        }

        private void LeaveApprovalForm_Load(object sender, EventArgs e)
        {
            LoadStatuses();
            LoadEmployees();
            LoadAdmins();
            LoadPendingRequests();
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Approved");
            cmbStatus.Items.Add("Rejected");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadAdmins()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Load only employees who have an account with the 'Admin' role
                    string query = @"SELECT e.EmployeeID, e.FullName 
                                   FROM Employees e 
                                   JOIN Users u ON e.EmployeeID = u.EmployeeID 
                                   WHERE u.Role = 'Admin'";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbApprovedBy.DataSource = dt;
                    cmbApprovedBy.DisplayMember = "FullName";
                    cmbApprovedBy.ValueMember = "EmployeeID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admins: " + ex.Message);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void LoadPendingRequests()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT lr.LeaveID, lr.EmployeeID, e.FullName, lr.LeaveType, lr.FromDate, lr.ToDate, lr.NumberOfDays, lr.Status, lr.Reason 
                                   FROM LeaveRequests lr 
                                   JOIN Employees e ON lr.EmployeeID = e.EmployeeID 
                                   WHERE 1=1";

                    if (cmbStatus.SelectedIndex >= 0)
                        query += " AND lr.Status = @status";
                    
                    if (cmbEmployee.SelectedIndex > 0)
                        query += " AND lr.EmployeeID = @empId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@empId", cmbEmployee.SelectedValue);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLeaveRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Load Button
        {
            LoadPendingRequests();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvLeaveRequests.SelectedRows.Count == 0 || dgvLeaveRequests.SelectedRows[0].Cells["Status"].Value?.ToString() != "Pending")
            {
                MessageBox.Show("Please select a PENDING leave request to approve.");
                return;
            }

            if (cmbApprovedBy.SelectedIndex < 0)
            {
                MessageBox.Show("Please select who is approving this leave.");
                return;
            }

            DataGridViewRow row = dgvLeaveRequests.SelectedRows[0];
            int leaveId = Convert.ToInt32(row.Cells["LeaveID"].Value ?? 0);
            int empId = Convert.ToInt32(row.Cells["EmployeeID"].Value ?? 0);
            string leaveType = row.Cells["LeaveType"].Value?.ToString() ?? "";
            int duration = Convert.ToInt32(row.Cells["NumberOfDays"].Value ?? 0);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Update Request Status with Auditor Info
                            string updateQuery = @"UPDATE LeaveRequests 
                                                 SET Status = 'Approved', ApprovedBy = @admin, 
                                                     ApprovalDate = @date, Comments = @comm 
                                                 WHERE LeaveID = @id";
                            MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn, trans);
                            cmdUpdate.Parameters.AddWithValue("@id", leaveId);
                            cmdUpdate.Parameters.AddWithValue("@admin", cmbApprovedBy.SelectedValue);
                            cmdUpdate.Parameters.AddWithValue("@date", dtpApprovalDate.Value.Date);
                            cmdUpdate.Parameters.AddWithValue("@comm", rtbComments.Text.Trim());
                            cmdUpdate.ExecuteNonQuery();

                            // 2. Subtract from Balance
                            string balanceCol = "";
                            if (leaveType == "Annual") balanceCol = "AnnualLeave";
                            else if (leaveType == "Medical") balanceCol = "MedicalLeave";
                            else if (leaveType == "Casual") balanceCol = "CasualLeave";

                            if (!string.IsNullOrEmpty(balanceCol))
                            {
                                string balanceQuery = $"UPDATE LeaveBalances SET {balanceCol} = {balanceCol} - @dur WHERE EmployeeID = @empId";
                                MySqlCommand cmdBalance = new MySqlCommand(balanceQuery, conn, trans);
                                cmdBalance.Parameters.AddWithValue("@dur", duration);
                                cmdBalance.Parameters.AddWithValue("@empId", empId);
                                cmdBalance.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Leave approved and employee balance updated!");
                            LoadPendingRequests();
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving leave: " + ex.Message);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvLeaveRequests.SelectedRows.Count == 0 || dgvLeaveRequests.SelectedRows[0].Cells["Status"].Value?.ToString() != "Pending")
            {
                MessageBox.Show("Please select a PENDING leave request to reject.");
                return;
            }

            if (cmbApprovedBy.SelectedIndex < 0)
            {
                MessageBox.Show("Please select who is rejecting this leave.");
                return;
            }

            int leaveId = Convert.ToInt32(dgvLeaveRequests.SelectedRows[0].Cells["LeaveID"].Value ?? 0);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE LeaveRequests 
                                   SET Status = 'Rejected', ApprovedBy = @admin, 
                                       ApprovalDate = @date, Comments = @comm 
                                   WHERE LeaveID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", leaveId);
                    cmd.Parameters.AddWithValue("@admin", cmbApprovedBy.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", dtpApprovalDate.Value.Date);
                    cmd.Parameters.AddWithValue("@comm", rtbComments.Text.Trim());
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Leave rejected.");
                    LoadPendingRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rejecting leave: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbComments.Clear();
            cmbStatus.SelectedIndex = 0;
            cmbEmployee.SelectedIndex = 0;
            LoadPendingRequests();
        }

        private void dgvLeaveRequests_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
