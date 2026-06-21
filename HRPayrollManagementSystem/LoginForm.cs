using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

            cmbRole.Items.Add("-- Select Role --");
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Employee");

            cmbRole.SelectedIndex = 0; 
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            chkShowPassword.Checked = false;
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (cmbRole.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Username=@username AND PasswordHash=@password AND Role=@role";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int empId = Convert.ToInt32(reader["EmployeeID"]);
                            MessageBox.Show("Login successful as " + role);
                            
                            // Important: Close the login reader before running a new query on the same connection
                            reader.Close();

                            if (role == "Admin")
                            {
                                DashboardForm dashboard = new DashboardForm();
                                dashboard.FormClosed += (s, args) => {
                                    if (args.CloseReason == CloseReason.UserClosing)
                                        Application.Exit();
                                };
                                dashboard.Show();
                            }
                            else if (role == "Employee")
                            {
                                // Check for leave status notifications (Beginner friendly way)
                                string leaveMsg = CheckLeaveStatus(empId, conn);
                                if (!string.IsNullOrEmpty(leaveMsg))
                                {
                                    MessageBox.Show(leaveMsg, "Leave Status Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                LeaveApplicationForm leaveApp = new LeaveApplicationForm(empId);
                                leaveApp.FormClosed += (s, args) => {
                                    if (args.CloseReason == CloseReason.UserClosing)
                                        Application.Exit();
                                };
                                leaveApp.Show();
                            }
                            
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username, password, or role.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
        }

        private string CheckLeaveStatus(int empId, MySqlConnection conn)
        {
            string message = "";
            try
            {
                // Find if today is within an approved leave period
                string query = "SELECT LeaveType, Status FROM LeaveRequests WHERE EmployeeID = @id AND Status = 'Approved' AND CURDATE() BETWEEN FromDate AND ToDate LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empId);
                
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        message = "Note: You have an APPROVED " + dr["LeaveType"].ToString() + " leave starting from today or currently active.";
                    }
                }
            }
            catch { } // Silent fail for notification
            return message;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
