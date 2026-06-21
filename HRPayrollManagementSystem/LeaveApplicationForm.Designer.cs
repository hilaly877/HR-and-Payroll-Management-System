namespace HRPayrollManagementSystem
{
    partial class LeaveApplicationForm
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
            groupBox1 = new GroupBox();
            txtDepartment = new TextBox();
            txtEmpName = new TextBox();
            txtEmpID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtCasual = new TextBox();
            txtMedical = new TextBox();
            txtAnnual = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnSubmit = new Button();
            btnClear = new Button();
            rtbReason = new RichTextBox();
            txtNoDays = new TextBox();
            cmbLeaveType = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dtpFrom = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtDepartment);
            groupBox1.Controls.Add(txtEmpName);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(562, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Leave Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(219, 162);
            txtDepartment.Margin = new Padding(4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(298, 35);
            txtDepartment.TabIndex = 5;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(219, 99);
            txtEmpName.Margin = new Padding(4);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(298, 35);
            txtEmpName.TabIndex = 4;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(219, 42);
            txtEmpID.Margin = new Padding(4);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(298, 35);
            txtEmpID.TabIndex = 3;
            txtEmpID.TextChanged += txtEmpID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Department :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Employee Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee ID :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtCasual);
            groupBox2.Controls.Add(txtMedical);
            groupBox2.Controls.Add(txtAnnual);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DarkBlue;
            groupBox2.Location = new Point(618, 15);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(469, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Leave Balance";
            // 
            // txtCasual
            // 
            txtCasual.Location = new Point(208, 154);
            txtCasual.Margin = new Padding(4);
            txtCasual.Name = "txtCasual";
            txtCasual.Size = new Size(155, 35);
            txtCasual.TabIndex = 5;
            // 
            // txtMedical
            // 
            txtMedical.Location = new Point(208, 100);
            txtMedical.Margin = new Padding(4);
            txtMedical.Name = "txtMedical";
            txtMedical.Size = new Size(155, 35);
            txtMedical.TabIndex = 4;
            // 
            // txtAnnual
            // 
            txtAnnual.Location = new Point(208, 42);
            txtAnnual.Margin = new Padding(4);
            txtAnnual.Name = "txtAnnual";
            txtAnnual.Size = new Size(155, 35);
            txtAnnual.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(30, 154);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 2;
            label6.Text = "Casual Leave :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(19, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 1;
            label5.Text = "Medical Leave :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 0;
            label4.Text = "Annual Leave :";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(dtpFrom);
            groupBox3.Controls.Add(btnSubmit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(rtbReason);
            groupBox3.Controls.Add(txtNoDays);
            groupBox3.Controls.Add(cmbLeaveType);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.DarkBlue;
            groupBox3.Location = new Point(13, 242);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(1074, 398);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Leave Details";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(670, 330);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(164, 55);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(875, 330);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 55);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // rtbReason
            // 
            rtbReason.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbReason.Location = new Point(105, 165);
            rtbReason.Margin = new Padding(4);
            rtbReason.Name = "rtbReason";
            rtbReason.Size = new Size(941, 143);
            rtbReason.TabIndex = 9;
            rtbReason.Text = "";
            rtbReason.TextChanged += rtbReason_TextChanged;
            // 
            // txtNoDays
            // 
            txtNoDays.Location = new Point(734, 108);
            txtNoDays.Margin = new Padding(4);
            txtNoDays.Name = "txtNoDays";
            txtNoDays.Size = new Size(312, 35);
            txtNoDays.TabIndex = 8;
            // 
            // cmbLeaveType
            // 
            cmbLeaveType.FormattingEnabled = true;
            cmbLeaveType.Location = new Point(149, 42);
            cmbLeaveType.Margin = new Padding(4);
            cmbLeaveType.Name = "cmbLeaveType";
            cmbLeaveType.Size = new Size(370, 36);
            cmbLeaveType.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(605, 116);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(121, 25);
            label11.TabIndex = 4;
            label11.Text = "No. of Days :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(8, 116);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(110, 25);
            label10.TabIndex = 3;
            label10.Text = "From Date :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(13, 171);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 2;
            label9.Text = "Reason :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(605, 48);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 1;
            label8.Text = "To Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(8, 49);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 0;
            label7.Text = "Leave Type :";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(734, 47);
            dtpFrom.Margin = new Padding(4, 5, 4, 5);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(312, 35);
            dtpFrom.TabIndex = 11;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(149, 108);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(370, 35);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // LeaveApplicationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 646);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            this.Name = "LeaveApplicationForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Leave Application Form";
            this.Load += LeaveApplicationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDepartment;
        private TextBox txtEmpName;
        private TextBox txtEmpID;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtCasual;
        private TextBox txtMedical;
        private TextBox txtAnnual;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtNoDays;
        private ComboBox cmbLeaveType;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnSubmit;
        private Button btnClear;
        private RichTextBox rtbReason;
        private DateTimePicker dtpFrom;
        private DateTimePicker dateTimePicker1;
    }
}