using MySql.Data.MySqlClient;
using System.Data;

namespace HRPayrollManagementSystem
{
    public partial class DashboardForm : Form
    {
        // Database connection string
        string connectionString = "server=localhost;database=hrpayrolldb;uid=root;pwd=1234;";

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Set current date on dashboard
            lblDate.Text = DateTime.Now.ToLongDateString();
            
            // Load counts for the dashboard cards
            LoadDashboardCounts();
            
            // Load recent activities into the grid
            LoadRecentActivities();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Get Total Employees
                    string empQuery = "SELECT COUNT(*) FROM Employees";
                    MySqlCommand empCmd = new MySqlCommand(empQuery, conn);
                    lblTotalEmployeesCount.Text = "👥 " + (empCmd.ExecuteScalar()?.ToString() ?? "0");

                    // 2. Get Today's Present Count
                    string presentQuery = "SELECT COUNT(*) FROM Attendance WHERE AttendanceDate = CURDATE() AND Status = 'Present'";
                    MySqlCommand presentCmd = new MySqlCommand(presentQuery, conn);
                    lblPresentCount.Text = "📅 " + (presentCmd.ExecuteScalar()?.ToString() ?? "0");

                    // 3. Get Pending Leave Requests
                    string leaveQuery = "SELECT COUNT(*) FROM LeaveRequests WHERE Status = 'Pending'";
                    MySqlCommand leaveCmd = new MySqlCommand(leaveQuery, conn);
                    label20.Text = "📝 " + (leaveCmd.ExecuteScalar()?.ToString() ?? "0");

                    // 4. Get Total Departments
                    string deptQuery = "SELECT COUNT(*) FROM Departments";
                    MySqlCommand deptCmd = new MySqlCommand(deptQuery, conn);
                    label6.Text = "🏢 " + (deptCmd.ExecuteScalar()?.ToString() ?? "0");

                    // 5. Monthly Payroll Summary (Sample calculation for the month)
                    string payrollQuery = "SELECT SUM(NetSalary) FROM Payroll WHERE PayrollMonth = MONTH(CURDATE()) AND PayrollYear = YEAR(CURDATE())";
                    MySqlCommand payrollCmd = new MySqlCommand(payrollQuery, conn);
                    object? payrollSum = payrollCmd.ExecuteScalar();
                    lblMonthPayroll.Text = "LKR " + (payrollSum != null && payrollSum != DBNull.Value ? Convert.ToDecimal(payrollSum).ToString("N2") : "0.00");
                    lblMonth.Text = DateTime.Now.ToString("MMMM yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void LoadRecentActivities()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Load a mix of recent activities (Leave Requests and New Employees)
                    string query = @"
                        (SELECT 'Leave' as Category, e.FullName as EmployeeName, lr.LeaveType as Activity, lr.Status, lr.FromDate as ActivityDate
                         FROM LeaveRequests lr 
                         JOIN Employees e ON lr.EmployeeID = e.EmployeeID)
                        UNION
                        (SELECT 'New Hire' as Category, FullName, 'Employee Joined', Status, JoiningDate
                         FROM Employees)
                        ORDER BY ActivityDate DESC LIMIT 5";
                    
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvActivities.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Show error if activities fail
                MessageBox.Show("Error loading activities: " + ex.Message);
            }
        }

        // Navigation Buttons Implementations
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Already on Dashboard
        }

        private void btnEmployeeRegistration_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationForm erf = new EmployeeRegistrationForm();
            erf.ShowDialog();
            RefreshDashboard();
        }

        private void btnEmployeeDirectory_Click(object sender, EventArgs e)
        {
            EmployeeDirectoryForm edf = new EmployeeDirectoryForm();
            edf.ShowDialog();
            RefreshDashboard();
        }

        private void btnAttendanceMgt_Click(object sender, EventArgs e)
        {
            AttendanceManagementForm amf = new AttendanceManagementForm();
            amf.ShowDialog();
            RefreshDashboard();
        }

        private void btnLeaveApproval_Click(object sender, EventArgs e)
        {
            LeaveApprovalForm leaf = new LeaveApprovalForm();
            leaf.ShowDialog();
            RefreshDashboard();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentDesignationForm ddf = new DepartmentDesignationForm();
            ddf.ShowDialog();
            RefreshDashboard();
        }

        private void btnPayrollProcessing_Click(object sender, EventArgs e)
        {
            PayrollProcessingForm ppf = new PayrollProcessingForm();
            ppf.ShowDialog();
            RefreshDashboard();
        }

        private void btnReportsViewer_Click(object sender, EventArgs e)
        {
            ReportViewerForm rvf = new ReportViewerForm();
            rvf.ShowDialog();
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            LoadDashboardCounts();
            LoadRecentActivities();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // This is actually the Logout button in the designer
            LoginForm log = new LoginForm();
            log.Show();
            this.Close();
        }

        // Empty events from designer
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void btnNotification_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label24_Click(object sender, EventArgs e) { }
        private void dgvActivities_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lnkViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void lblPresent_Click(object sender, EventArgs e) { }
    }
}
