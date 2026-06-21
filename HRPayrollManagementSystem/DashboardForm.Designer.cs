namespace HRPayrollManagementSystem
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDashboard = new Button();
            btnEmployeeRegistration = new Button();
            btnAttendanceMgt = new Button();
            btnLeaveApplication = new Button();
            btnPayrollProcessing = new Button();
            btnDepartments = new Button();
            btnReportsViewer = new Button();
            btnLogout = new Button();
            pnlmenu = new Panel();
            btnLeaveApproval = new Button();
            btnEmployeeDirectory = new Button();
            label4 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            lblPresentCount = new Label();
            lblPresent = new Label();
            panel5 = new Panel();
            lblTotalEmployeesCount = new Label();
            lblTotalEmployeesTitle = new Label();
            panel10 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            lblMonth = new Label();
            lblMonthPayroll = new Label();
            label3 = new Label();
            panel7 = new Panel();
            label20 = new Label();
            label19 = new Label();
            panel8 = new Panel();
            panel3 = new Panel();
            lblDate = new Label();
            dgvActivities = new DataGridView();
            label7 = new Label();
            label9 = new Label();
            pnlmenu.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivities).BeginInit();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(30, 23);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(279, 55);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnEmployeeRegistration
            // 
            btnEmployeeRegistration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeRegistration.Location = new Point(30, 83);
            btnEmployeeRegistration.Margin = new Padding(4);
            btnEmployeeRegistration.Name = "btnEmployeeRegistration";
            btnEmployeeRegistration.Size = new Size(279, 51);
            btnEmployeeRegistration.TabIndex = 3;
            btnEmployeeRegistration.Text = "👥 Employee Registration";
            btnEmployeeRegistration.UseVisualStyleBackColor = true;
            btnEmployeeRegistration.Click += btnEmployeeRegistration_Click;
            // 
            // btnAttendanceMgt
            // 
            btnAttendanceMgt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendanceMgt.Location = new Point(30, 198);
            btnAttendanceMgt.Margin = new Padding(4);
            btnAttendanceMgt.Name = "btnAttendanceMgt";
            btnAttendanceMgt.Size = new Size(279, 54);
            btnAttendanceMgt.TabIndex = 4;
            btnAttendanceMgt.Text = "🕒 Attendance Management";
            btnAttendanceMgt.UseVisualStyleBackColor = true;
            btnAttendanceMgt.Click += btnAttendanceMgt_Click;
            // 
            // btnLeaveApplication
            // 
            btnLeaveApplication.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaveApplication.Location = new Point(30, 255);
            btnLeaveApplication.Margin = new Padding(4);
            btnLeaveApplication.Name = "btnLeaveApplication";
            btnLeaveApplication.Size = new Size(279, 51);
            btnLeaveApplication.TabIndex = 5;
            btnLeaveApplication.Text = "📝 Leave Application";
            btnLeaveApplication.UseVisualStyleBackColor = true;
            // 
            // btnPayrollProcessing
            // 
            btnPayrollProcessing.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayrollProcessing.Location = new Point(30, 360);
            btnPayrollProcessing.Margin = new Padding(4);
            btnPayrollProcessing.Name = "btnPayrollProcessing";
            btnPayrollProcessing.Size = new Size(279, 49);
            btnPayrollProcessing.TabIndex = 6;
            btnPayrollProcessing.Text = "💰 Payroll Processing";
            btnPayrollProcessing.UseVisualStyleBackColor = true;
            btnPayrollProcessing.Click += btnPayrollProcessing_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepartments.Location = new Point(30, 310);
            btnDepartments.Margin = new Padding(4);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(279, 45);
            btnDepartments.TabIndex = 7;
            btnDepartments.Text = "🏢 Department & Designation";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnReportsViewer
            // 
            btnReportsViewer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportsViewer.Location = new Point(30, 413);
            btnReportsViewer.Margin = new Padding(4);
            btnReportsViewer.Name = "btnReportsViewer";
            btnReportsViewer.Size = new Size(279, 50);
            btnReportsViewer.TabIndex = 8;
            btnReportsViewer.Text = "📊 Reports Viewer";
            btnReportsViewer.UseVisualStyleBackColor = true;
            btnReportsViewer.Click += btnReportsViewer_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(30, 469);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(279, 52);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "↪️ Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnSettings_Click;
            // 
            // pnlmenu
            // 
            pnlmenu.BackColor = Color.DarkBlue;
            pnlmenu.Controls.Add(btnLeaveApproval);
            pnlmenu.Controls.Add(btnEmployeeDirectory);
            pnlmenu.Controls.Add(btnLogout);
            pnlmenu.Controls.Add(btnReportsViewer);
            pnlmenu.Controls.Add(btnDepartments);
            pnlmenu.Controls.Add(btnPayrollProcessing);
            pnlmenu.Controls.Add(btnAttendanceMgt);
            pnlmenu.Controls.Add(btnEmployeeRegistration);
            pnlmenu.Controls.Add(btnDashboard);
            pnlmenu.Dock = DockStyle.Left;
            pnlmenu.Location = new Point(0, 0);
            pnlmenu.Margin = new Padding(4);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(338, 619);
            pnlmenu.TabIndex = 0;
            pnlmenu.Paint += panel1_Paint;
            // 
            // btnLeaveApproval
            // 
            btnLeaveApproval.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaveApproval.Location = new Point(30, 257);
            btnLeaveApproval.Margin = new Padding(4);
            btnLeaveApproval.Name = "btnLeaveApproval";
            btnLeaveApproval.Size = new Size(279, 49);
            btnLeaveApproval.TabIndex = 11;
            btnLeaveApproval.Text = "📝 Leave Approval";
            btnLeaveApproval.UseVisualStyleBackColor = true;
            btnLeaveApproval.Click += btnLeaveApproval_Click;
            // 
            // btnEmployeeDirectory
            // 
            btnEmployeeDirectory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeDirectory.Location = new Point(30, 139);
            btnEmployeeDirectory.Margin = new Padding(4);
            btnEmployeeDirectory.Name = "btnEmployeeDirectory";
            btnEmployeeDirectory.Size = new Size(279, 56);
            btnEmployeeDirectory.TabIndex = 10;
            btnEmployeeDirectory.Text = "👥 Employee Directory";
            btnEmployeeDirectory.UseVisualStyleBackColor = true;
            btnEmployeeDirectory.Click += btnEmployeeDirectory_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(329, 48);
            label4.TabIndex = 1;
            label4.Text = "Welcome , Admin!";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 86);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1139, 131);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.ForestGreen;
            panel6.Controls.Add(lblPresentCount);
            panel6.Controls.Add(lblPresent);
            panel6.Location = new Point(273, 0);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(221, 148);
            panel6.TabIndex = 10;
            // 
            // lblPresentCount
            // 
            lblPresentCount.AutoSize = true;
            lblPresentCount.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresentCount.ForeColor = Color.White;
            lblPresentCount.Location = new Point(35, 59);
            lblPresentCount.Margin = new Padding(4, 0, 4, 0);
            lblPresentCount.Name = "lblPresentCount";
            lblPresentCount.Size = new Size(148, 48);
            lblPresentCount.TabIndex = 1;
            lblPresentCount.Text = "📅 N/A";
            // 
            // lblPresent
            // 
            lblPresent.AutoSize = true;
            lblPresent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresent.ForeColor = Color.White;
            lblPresent.Location = new Point(16, 14);
            lblPresent.Margin = new Padding(4, 0, 4, 0);
            lblPresent.Name = "lblPresent";
            lblPresent.Size = new Size(175, 32);
            lblPresent.TabIndex = 0;
            lblPresent.Text = "Present Today";
            lblPresent.Click += lblPresent_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Controls.Add(lblTotalEmployeesCount);
            panel5.Controls.Add(lblTotalEmployeesTitle);
            panel5.Location = new Point(34, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 148);
            panel5.TabIndex = 9;
            // 
            // lblTotalEmployeesCount
            // 
            lblTotalEmployeesCount.AutoSize = true;
            lblTotalEmployeesCount.BackColor = Color.RoyalBlue;
            lblTotalEmployeesCount.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEmployeesCount.ForeColor = Color.White;
            lblTotalEmployeesCount.Location = new Point(42, 62);
            lblTotalEmployeesCount.Margin = new Padding(4, 0, 4, 0);
            lblTotalEmployeesCount.Name = "lblTotalEmployeesCount";
            lblTotalEmployeesCount.Size = new Size(137, 44);
            lblTotalEmployeesCount.TabIndex = 1;
            lblTotalEmployeesCount.Text = "📅 N/A";
            // 
            // lblTotalEmployeesTitle
            // 
            lblTotalEmployeesTitle.AutoSize = true;
            lblTotalEmployeesTitle.BackColor = Color.RoyalBlue;
            lblTotalEmployeesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEmployeesTitle.ForeColor = Color.White;
            lblTotalEmployeesTitle.Location = new Point(11, 14);
            lblTotalEmployeesTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalEmployeesTitle.Name = "lblTotalEmployeesTitle";
            lblTotalEmployeesTitle.Size = new Size(199, 32);
            lblTotalEmployeesTitle.TabIndex = 0;
            lblTotalEmployeesTitle.Text = "Total Employees";
            // 
            // panel10
            // 
            panel10.BackColor = Color.SaddleBrown;
            panel10.Controls.Add(label6);
            panel10.Controls.Add(label5);
            panel10.Location = new Point(939, 86);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(181, 131);
            panel10.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(42, 62);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 48);
            label6.TabIndex = 1;
            label6.Text = "🏬 N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 14);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 32);
            label5.TabIndex = 0;
            label5.Text = "Departments";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkViolet;
            panel9.Controls.Add(lblMonth);
            panel9.Controls.Add(lblMonthPayroll);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(725, 86);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(202, 131);
            panel9.TabIndex = 12;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.Black;
            lblMonth.Location = new Point(30, 49);
            lblMonth.Margin = new Padding(4, 0, 4, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(124, 32);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "June 2026";
            // 
            // lblMonthPayroll
            // 
            lblMonthPayroll.AutoSize = true;
            lblMonthPayroll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthPayroll.ForeColor = Color.White;
            lblMonthPayroll.Location = new Point(4, 84);
            lblMonthPayroll.Margin = new Padding(4, 0, 4, 0);
            lblMonthPayroll.Name = "lblMonthPayroll";
            lblMonthPayroll.Size = new Size(107, 32);
            lblMonthPayroll.TabIndex = 1;
            lblMonthPayroll.Text = "LKR N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 0;
            label3.Text = "Monthly Payroll";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkOrange;
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(502, 86);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(215, 131);
            panel7.TabIndex = 11;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(40, 62);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(148, 48);
            label20.TabIndex = 2;
            label20.Text = "📅 N/A";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(20, 14);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(179, 32);
            label19.TabIndex = 1;
            label19.Text = "Pending Leave";
            // 
            // panel8
            // 
            panel8.Location = new Point(274, 0);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 178);
            panel8.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(dgvActivities);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(338, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1132, 619);
            panel3.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(875, 38);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "N/A";
            // 
            // dgvActivities
            // 
            dgvActivities.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivities.Location = new Point(35, 297);
            dgvActivities.Margin = new Padding(4);
            dgvActivities.Name = "dgvActivities";
            dgvActivities.RowHeadersWidth = 51;
            dgvActivities.Size = new Size(1043, 263);
            dgvActivities.TabIndex = 6;
            dgvActivities.CellContentClick += dgvActivities_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 255);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(224, 38);
            label7.TabIndex = 5;
            label7.Text = "Recent Activities";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(791, 32);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 32);
            label9.TabIndex = 4;
            label9.Text = "Date :";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 619);
            Controls.Add(panel3);
            Controls.Add(pnlmenu);
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            pnlmenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivities).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDashboard;
        private Button btnEmployeeRegistration;
        private Button btnAttendanceMgt;
        private Button btnLeaveApplication;
        private Button btnPayrollProcessing;
        private Button btnDepartments;
        private Button btnReportsViewer;
        private Button btnLogout;
        private Panel pnlmenu;
        private Label label4;
        private Panel panel4;
        private Panel panel7;
        private Label label20;
        private Label label19;
        private Panel panel8;
        private Panel panel6;
        private Label lblPresentCount;
        private Label lblPresent;
        private Panel panel5;
        private Label lblTotalEmployeesCount;
        private Label lblTotalEmployeesTitle;
        private Panel panel3;
        private Label label9;
        private Panel panel10;
        private Panel panel9;
        private Label lblMonth;
        private Label lblMonthPayroll;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private DataGridView dgvActivities;
        private Label lblDate;
        private Button btnEmployeeDirectory;
        private Button btnLeaveApproval;
    }
}
