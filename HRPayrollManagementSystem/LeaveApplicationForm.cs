using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class LeaveApplicationForm : Form
    {
        // Connection string for the database
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";
        int loggedInEmpId = 0;

        public LeaveApplicationForm()
        {
            InitializeComponent();
        }

        public LeaveApplicationForm(int empId)
        {
            InitializeComponent();
            loggedInEmpId = empId;
        }

        private void LeaveApplicationForm_Load(object sender, EventArgs e)
        {
            // Populate Leave Types
            cmbLeaveType.Items.Add("Annual");
            cmbLeaveType.Items.Add("Medical");
            cmbLeaveType.Items.Add("Casual");
            cmbLeaveType.SelectedIndex = 0;

            // Set default dates
            dateTimePicker1.Value = DateTime.Today; // This is From Date
            dtpFrom.Value = DateTime.Today;        // This is To Date

            if (loggedInEmpId > 0)
            {
                txtEmpID.Text = loggedInEmpId.ToString();
                txtEmpID.ReadOnly = true;
                // TextChanged event will fire automatically and load the details
            }
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                ClearEmployeeDetails();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // 1. Fetch Employee and Department info
                    string query = @"SELECT e.FullName, d.DepartmentName 
                                   FROM Employees e 
                                   JOIN Departments d ON e.DepartmentID = d.DepartmentID 
                                   WHERE e.EmployeeID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtEmpID.Text.Trim());

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtEmpName.Text = dr["FullName"]?.ToString() ?? "";
                            txtDepartment.Text = dr["DepartmentName"]?.ToString() ?? "";
                            dr.Close();

                            // 2. Fetch Leave Balances
                            LoadLeaveBalances(txtEmpID.Text.Trim());
                        }
                        else
                        {
                            dr.Close();
                            ClearEmployeeDetails();
                        }
                    }
                }
            }
            catch
            {
                // Silent catch during typing
            }
        }

        private void LoadLeaveBalances(string empId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT AnnualLeave, MedicalLeave, CasualLeave FROM LeaveBalances WHERE EmployeeID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", empId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtAnnual.Text = dr["AnnualLeave"]?.ToString() ?? "0";
                            txtMedical.Text = dr["MedicalLeave"]?.ToString() ?? "0";
                            txtCasual.Text = dr["CasualLeave"]?.ToString() ?? "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading balance: " + ex.Message);
            }
        }

        private void ClearEmployeeDetails()
        {
            txtEmpName.Clear();
            txtDepartment.Clear();
            txtAnnual.Clear();
            txtMedical.Clear();
            txtCasual.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => CalculateDays();
        private void dtpFrom_ValueChanged(object sender, EventArgs e) => CalculateDays();

        private void CalculateDays()
        {
            DateTime fromDate = dateTimePicker1.Value.Date; // From
            DateTime toDate = dtpFrom.Value.Date;          // To
            
            if (toDate < fromDate)
            {
                txtNoDays.Text = "0";
                return;
            }

            double days = (toDate - fromDate).TotalDays + 1; // Inclusive
            txtNoDays.Text = days.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset only leave-specific details, preserve Employee ID and loaded details
            rtbReason.Clear();
            txtNoDays.Clear();
            cmbLeaveType.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpName.Text))
            {
                MessageBox.Show("Please enter a valid Employee ID.");
                return;
            }

            int requestedDays = 0;
            if (!int.TryParse(txtNoDays.Text, out requestedDays) || requestedDays <= 0)
            {
                MessageBox.Show("Invalid number of days.");
                return;
            }

            string leaveType = cmbLeaveType.Text;
            int currentBalance = 0;

            // Check if balance is sufficient
            if (leaveType == "Annual") currentBalance = int.Parse(string.IsNullOrEmpty(txtAnnual.Text) ? "0" : txtAnnual.Text);
            else if (leaveType == "Medical") currentBalance = int.Parse(string.IsNullOrEmpty(txtMedical.Text) ? "0" : txtMedical.Text);
            else if (leaveType == "Casual") currentBalance = int.Parse(string.IsNullOrEmpty(txtCasual.Text) ? "0" : txtCasual.Text);

            if (requestedDays > currentBalance)
            {
                MessageBox.Show("Insufficient " + leaveType + " leave balance! (Available: " + currentBalance + ")");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO LeaveRequests (EmployeeID, LeaveType, FromDate, ToDate, NumberOfDays, Reason, Status) 
                                   VALUES (@empId, @type, @from, @to, @dur, @reason, 'Pending')";
                    
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@empId", txtEmpID.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", leaveType);
                    cmd.Parameters.AddWithValue("@from", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@to", dtpFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@dur", requestedDays);
                    cmd.Parameters.AddWithValue("@reason", rtbReason.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Leave request submitted successfully and is pending approval.");
                    this.Close(); // Close the form after successful submission
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting leave: " + ex.Message);
            }
        }

        private void rtbReason_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
