namespace HRPayrollManagementSystem
{
    partial class EmployeeRegistrationForm
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
            dtpDOB = new DateTimePicker();
            txtAddress = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtNIC = new TextBox();
            label4 = new Label();
            cmbGender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtEmployeeID = new TextBox();
            groupBox2 = new GroupBox();
            dtpJoiningDate = new DateTimePicker();
            cmbDesignation = new ComboBox();
            cmbDepartment = new ComboBox();
            label12 = new Label();
            txtBasicSalary = new TextBox();
            label13 = new Label();
            cmbStatus = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            txtUsername = new TextBox();
            label10 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtConfirmPassword = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNIC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmployeeID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(181, 131);
            dtpDOB.Margin = new Padding(4, 5, 4, 5);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(182, 31);
            dtpDOB.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(124, 328);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(254, 144);
            txtAddress.TabIndex = 15;
            txtAddress.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 331);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 14;
            label8.Text = "Address : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 287);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 12;
            label7.Text = "Email : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 31);
            txtEmail.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 250);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 10;
            label6.Text = "Phone : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(181, 244);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(182, 31);
            txtPhone.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 211);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 8;
            label5.Text = "NIC : ";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(181, 205);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(182, 31);
            txtNIC.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 174);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 7;
            label4.Text = "Gender :";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(181, 166);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 33);
            cmbGender.TabIndex = 6;
            cmbGender.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 129);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Full Name : ";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(181, 92);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(182, 31);
            txtFullName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Employee ID : ";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(181, 55);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(182, 31);
            txtEmployeeID.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dtpJoiningDate);
            groupBox2.Controls.Add(cmbDesignation);
            groupBox2.Controls.Add(cmbDepartment);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtBasicSalary);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmbStatus);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(441, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 264);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employment Information";
            // 
            // dtpJoiningDate
            // 
            dtpJoiningDate.Format = DateTimePickerFormat.Short;
            dtpJoiningDate.Location = new Point(181, 129);
            dtpJoiningDate.Margin = new Padding(4, 5, 4, 5);
            dtpJoiningDate.Name = "dtpJoiningDate";
            dtpJoiningDate.Size = new Size(182, 31);
            dtpJoiningDate.TabIndex = 18;
            // 
            // cmbDesignation
            // 
            cmbDesignation.FormattingEnabled = true;
            cmbDesignation.Location = new Point(181, 90);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(182, 33);
            cmbDesignation.TabIndex = 17;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(181, 50);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(182, 33);
            cmbDepartment.TabIndex = 16;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 174);
            label12.Name = "label12";
            label12.Size = new Size(117, 25);
            label12.TabIndex = 8;
            label12.Text = "Basic Salary : ";
            // 
            // txtBasicSalary
            // 
            txtBasicSalary.Location = new Point(181, 169);
            txtBasicSalary.Name = "txtBasicSalary";
            txtBasicSalary.Size = new Size(182, 31);
            txtBasicSalary.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 220);
            label13.Name = "label13";
            label13.Size = new Size(69, 25);
            label13.TabIndex = 7;
            label13.Text = "Status :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(181, 212);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 6;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 129);
            label14.Name = "label14";
            label14.Size = new Size(119, 25);
            label14.TabIndex = 4;
            label14.Text = "Joining Date :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 95);
            label15.Name = "label15";
            label15.Size = new Size(121, 25);
            label15.TabIndex = 2;
            label15.Text = "Designation : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 58);
            label16.Name = "label16";
            label16.Size = new Size(121, 25);
            label16.TabIndex = 1;
            label16.Text = "Department : ";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtUsername);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtConfirmPassword);
            groupBox3.Location = new Point(441, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(392, 227);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 51);
            label11.Name = "label11";
            label11.Size = new Size(105, 25);
            label11.TabIndex = 12;
            label11.Text = "Username : ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(196, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(167, 31);
            txtUsername.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 103);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 10;
            label10.Text = "Password : ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(196, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(167, 31);
            txtPassword.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 151);
            label9.Name = "label9";
            label9.Size = new Size(170, 25);
            label9.TabIndex = 8;
            label9.Text = "Confirm Password : ";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(197, 145);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(166, 31);
            txtConfirmPassword.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.Location = new Point(48, 551);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.Location = new Point(222, 551);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.Location = new Point(388, 551);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.Location = new Point(561, 551);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom;
            btnSearch.Location = new Point(721, 551);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // EmployeeRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 635);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmployeeRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Registration";
            Load += Employee_Registration_Load;
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
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtEmployeeID;
        private Label label5;
        private TextBox txtNIC;
        private Label label4;
        private ComboBox cmbGender;
        private Label label3;
        private Label label8;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPhone;
        private RichTextBox txtAddress;
        private GroupBox groupBox2;
        private ComboBox cmbDesignation;
        private ComboBox cmbDepartment;
        private Label label12;
        private TextBox txtBasicSalary;
        private Label label13;
        private ComboBox cmbStatus;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox txtUsername;
        private Label label10;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtConfirmPassword;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private DateTimePicker dtpDOB;
        private DateTimePicker dtpJoiningDate;
    }
}