namespace HRPayrollManagementSystem
{
    partial class LeaveApprovalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLeaveApproval = new GroupBox();
            dgvLeaveRequests = new DataGridView();
            cmbStatus = new ComboBox();
            button1 = new Button();
            cmbEmployee = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grpApprovalDetails = new GroupBox();
            btnClear = new Button();
            btnReject = new Button();
            btnApprove = new Button();
            rtbComments = new RichTextBox();
            cmbApprovedBy = new ComboBox();
            dtpApprovalDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            grpLeaveApproval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveRequests).BeginInit();
            grpApprovalDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpLeaveApproval
            // 
            grpLeaveApproval.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLeaveApproval.Controls.Add(dgvLeaveRequests);
            grpLeaveApproval.Controls.Add(cmbStatus);
            grpLeaveApproval.Controls.Add(button1);
            grpLeaveApproval.Controls.Add(cmbEmployee);
            grpLeaveApproval.Controls.Add(label2);
            grpLeaveApproval.Controls.Add(label1);
            grpLeaveApproval.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpLeaveApproval.ForeColor = Color.DarkBlue;
            grpLeaveApproval.Location = new Point(13, 2);
            grpLeaveApproval.Margin = new Padding(4);
            grpLeaveApproval.Name = "grpLeaveApproval";
            grpLeaveApproval.Padding = new Padding(4);
            grpLeaveApproval.Size = new Size(1128, 328);
            grpLeaveApproval.TabIndex = 0;
            grpLeaveApproval.TabStop = false;
            grpLeaveApproval.Text = " Leave Approval";
            // 
            // dgvLeaveRequests
            // 
            dgvLeaveRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLeaveRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLeaveRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveRequests.Location = new Point(25, 107);
            dgvLeaveRequests.Margin = new Padding(4);
            dgvLeaveRequests.Name = "dgvLeaveRequests";
            dgvLeaveRequests.ReadOnly = true;
            dgvLeaveRequests.RowHeadersWidth = 51;
            dgvLeaveRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaveRequests.Size = new Size(1081, 210);
            dgvLeaveRequests.TabIndex = 5;
            dgvLeaveRequests.CellContentClick += dgvLeaveRequests_CellContentClick;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(117, 46);
            cmbStatus.Margin = new Padding(4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(286, 36);
            cmbStatus.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(955, 34);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 4;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(585, 46);
            cmbEmployee.Margin = new Padding(4);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(328, 36);
            cmbEmployee.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(472, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Employee :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Status :";
            // 
            // grpApprovalDetails
            // 
            grpApprovalDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpApprovalDetails.Controls.Add(btnClear);
            grpApprovalDetails.Controls.Add(btnReject);
            grpApprovalDetails.Controls.Add(btnApprove);
            grpApprovalDetails.Controls.Add(rtbComments);
            grpApprovalDetails.Controls.Add(cmbApprovedBy);
            grpApprovalDetails.Controls.Add(dtpApprovalDate);
            grpApprovalDetails.Controls.Add(label5);
            grpApprovalDetails.Controls.Add(label4);
            grpApprovalDetails.Controls.Add(label3);
            grpApprovalDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpApprovalDetails.ForeColor = Color.DarkBlue;
            grpApprovalDetails.Location = new Point(13, 338);
            grpApprovalDetails.Margin = new Padding(4);
            grpApprovalDetails.Name = "grpApprovalDetails";
            grpApprovalDetails.Padding = new Padding(4);
            grpApprovalDetails.Size = new Size(1128, 299);
            grpApprovalDetails.TabIndex = 1;
            grpApprovalDetails.TabStop = false;
            grpApprovalDetails.Text = "Approval Details";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(858, 224);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(159, 56);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Red;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(561, 224);
            btnReject.Margin = new Padding(4);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(159, 56);
            btnReject.TabIndex = 7;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.DarkGreen;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(226, 224);
            btnApprove.Margin = new Padding(4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(161, 56);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // rtbComments
            // 
            rtbComments.Location = new Point(210, 100);
            rtbComments.Margin = new Padding(4);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(879, 105);
            rtbComments.TabIndex = 5;
            rtbComments.Text = "";
            // 
            // cmbApprovedBy
            // 
            cmbApprovedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApprovedBy.FormattingEnabled = true;
            cmbApprovedBy.Location = new Point(210, 40);
            cmbApprovedBy.Margin = new Padding(4);
            cmbApprovedBy.Name = "cmbApprovedBy";
            cmbApprovedBy.Size = new Size(294, 36);
            cmbApprovedBy.TabIndex = 4;
            // 
            // dtpApprovalDate
            // 
            dtpApprovalDate.Format = DateTimePickerFormat.Short;
            dtpApprovalDate.Location = new Point(778, 36);
            dtpApprovalDate.Margin = new Padding(4);
            dtpApprovalDate.Name = "dtpApprovalDate";
            dtpApprovalDate.Size = new Size(312, 35);
            dtpApprovalDate.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 2;
            label5.Text = "Comments :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(606, 41);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 1;
            label4.Text = "Approval Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 0;
            label3.Text = "Approved By :";
            // 
            // LeaveApprovalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 642);
            Controls.Add(grpApprovalDetails);
            Controls.Add(grpLeaveApproval);
            Margin = new Padding(4);
            Name = "LeaveApprovalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leave Approval Form";
            Load += LeaveApprovalForm_Load;
            grpLeaveApproval.ResumeLayout(false);
            grpLeaveApproval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveRequests).EndInit();
            grpApprovalDetails.ResumeLayout(false);
            grpApprovalDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLeaveApproval;
        private Button button1;
        private ComboBox cmbEmployee;
        private Label label2;
        private Label label1;
        private ComboBox cmbStatus;
        private DataGridView dgvLeaveRequests;
        private GroupBox grpApprovalDetails;
        private Button btnClear;
        private Button btnReject;
        private Button btnApprove;
        private RichTextBox rtbComments;
        private ComboBox cmbApprovedBy;
        private DateTimePicker dtpApprovalDate;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}