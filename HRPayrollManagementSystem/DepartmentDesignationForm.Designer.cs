namespace HRPayrollManagementSystem
{
    partial class DepartmentDesignationForm
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
            btnDeleteDept = new Button();
            button4 = new Button();
            btnAddDept = new Button();
            tcDeptDesign = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dgvDepartment = new DataGridView();
            txtDescription = new TextBox();
            txtDeptName = new TextBox();
            txtDeptId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnClearDesignation = new Button();
            btnDeleteDesignation = new Button();
            btnUpdateDesignation = new Button();
            btnAddDesignation = new Button();
            txtDescriptionDesignation = new TextBox();
            label7 = new Label();
            cmbDepartmentDesignation = new ComboBox();
            dgvDesignation = new DataGridView();
            txtDesignationName = new TextBox();
            txtDesignationID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            tcDeptDesign.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesignation).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteDept
            // 
            btnDeleteDept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteDept.BackColor = Color.Red;
            btnDeleteDept.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteDept.Location = new Point(822, 376);
            btnDeleteDept.Margin = new Padding(4);
            btnDeleteDept.Name = "btnDeleteDept";
            btnDeleteDept.Size = new Size(118, 44);
            btnDeleteDept.TabIndex = 4;
            btnDeleteDept.Text = "Delete";
            btnDeleteDept.UseVisualStyleBackColor = false;
            btnDeleteDept.Click += btnDeleteDept_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(988, 376);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(118, 44);
            button4.TabIndex = 5;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnAddDept
            // 
            btnAddDept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddDept.BackColor = Color.Green;
            btnAddDept.ForeColor = SystemColors.Control;
            btnAddDept.Location = new Point(483, 376);
            btnAddDept.Margin = new Padding(4);
            btnAddDept.Name = "btnAddDept";
            btnAddDept.Size = new Size(118, 44);
            btnAddDept.TabIndex = 2;
            btnAddDept.Text = "Add";
            btnAddDept.UseVisualStyleBackColor = false;
            btnAddDept.Click += btnAddDept_Click;
            // 
            // tcDeptDesign
            // 
            tcDeptDesign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcDeptDesign.Controls.Add(tabPage1);
            tcDeptDesign.Controls.Add(tabPage2);
            tcDeptDesign.Location = new Point(8, 45);
            tcDeptDesign.Margin = new Padding(4);
            tcDeptDesign.Name = "tcDeptDesign";
            tcDeptDesign.SelectedIndex = 0;
            tcDeptDesign.Size = new Size(1292, 502);
            tcDeptDesign.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(dgvDepartment);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(btnDeleteDept);
            tabPage1.Controls.Add(txtDeptName);
            tabPage1.Controls.Add(btnAddDept);
            tabPage1.Controls.Add(txtDeptId);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1284, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Departments";
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(652, 376);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 44);
            button1.TabIndex = 17;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(483, 4);
            dgvDepartment.Margin = new Padding(4);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.Size = new Size(793, 360);
            dgvDepartment.TabIndex = 10;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(240, 139);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(235, 139);
            txtDescription.TabIndex = 5;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(240, 85);
            txtDeptName.Margin = new Padding(4);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(235, 31);
            txtDeptName.TabIndex = 4;
            // 
            // txtDeptId
            // 
            txtDeptId.Location = new Point(240, 27);
            txtDeptId.Margin = new Padding(4);
            txtDeptId.Name = "txtDeptId";
            txtDeptId.Size = new Size(235, 31);
            txtDeptId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 30);
            label2.TabIndex = 1;
            label2.Text = "Department Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(22, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 0;
            label1.Text = "Department ID:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearDesignation);
            tabPage2.Controls.Add(btnDeleteDesignation);
            tabPage2.Controls.Add(btnUpdateDesignation);
            tabPage2.Controls.Add(btnAddDesignation);
            tabPage2.Controls.Add(txtDescriptionDesignation);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cmbDepartmentDesignation);
            tabPage2.Controls.Add(dgvDesignation);
            tabPage2.Controls.Add(txtDesignationName);
            tabPage2.Controls.Add(txtDesignationID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1284, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Designation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearDesignation
            // 
            btnClearDesignation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearDesignation.Location = new Point(1025, 375);
            btnClearDesignation.Margin = new Padding(4);
            btnClearDesignation.Name = "btnClearDesignation";
            btnClearDesignation.Size = new Size(118, 46);
            btnClearDesignation.TabIndex = 18;
            btnClearDesignation.Text = "Clear";
            btnClearDesignation.UseVisualStyleBackColor = true;
            btnClearDesignation.Click += btnClearDesignation_Click;
            // 
            // btnDeleteDesignation
            // 
            btnDeleteDesignation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteDesignation.BackColor = Color.Red;
            btnDeleteDesignation.ForeColor = Color.White;
            btnDeleteDesignation.Location = new Point(842, 375);
            btnDeleteDesignation.Margin = new Padding(4);
            btnDeleteDesignation.Name = "btnDeleteDesignation";
            btnDeleteDesignation.Size = new Size(118, 46);
            btnDeleteDesignation.TabIndex = 17;
            btnDeleteDesignation.Text = "Delete";
            btnDeleteDesignation.UseVisualStyleBackColor = false;
            btnDeleteDesignation.Click += btnDeleteDesignation_Click;
            // 
            // btnUpdateDesignation
            // 
            btnUpdateDesignation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateDesignation.BackColor = Color.Blue;
            btnUpdateDesignation.ForeColor = Color.White;
            btnUpdateDesignation.Location = new Point(655, 375);
            btnUpdateDesignation.Margin = new Padding(4);
            btnUpdateDesignation.Name = "btnUpdateDesignation";
            btnUpdateDesignation.Size = new Size(118, 46);
            btnUpdateDesignation.TabIndex = 16;
            btnUpdateDesignation.Text = "Update";
            btnUpdateDesignation.UseVisualStyleBackColor = false;
            btnUpdateDesignation.Click += btnUpdateDesignation_Click;
            // 
            // btnAddDesignation
            // 
            btnAddDesignation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddDesignation.BackColor = Color.Green;
            btnAddDesignation.ForeColor = SystemColors.ButtonHighlight;
            btnAddDesignation.Location = new Point(472, 375);
            btnAddDesignation.Margin = new Padding(4);
            btnAddDesignation.Name = "btnAddDesignation";
            btnAddDesignation.Size = new Size(118, 46);
            btnAddDesignation.TabIndex = 15;
            btnAddDesignation.Text = "Add";
            btnAddDesignation.UseVisualStyleBackColor = false;
            btnAddDesignation.Click += btnAddDesignation_Click;
            // 
            // txtDescriptionDesignation
            // 
            txtDescriptionDesignation.Location = new Point(269, 179);
            txtDescriptionDesignation.Margin = new Padding(4);
            txtDescriptionDesignation.Multiline = true;
            txtDescriptionDesignation.Name = "txtDescriptionDesignation";
            txtDescriptionDesignation.Size = new Size(188, 148);
            txtDescriptionDesignation.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 178);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 30);
            label7.TabIndex = 13;
            label7.Text = "Description:";
            // 
            // cmbDepartmentDesignation
            // 
            cmbDepartmentDesignation.FormattingEnabled = true;
            cmbDepartmentDesignation.Location = new Point(269, 130);
            cmbDepartmentDesignation.Margin = new Padding(4);
            cmbDepartmentDesignation.Name = "cmbDepartmentDesignation";
            cmbDepartmentDesignation.Size = new Size(188, 33);
            cmbDepartmentDesignation.TabIndex = 12;
            // 
            // dgvDesignation
            // 
            dgvDesignation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDesignation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesignation.Location = new Point(471, 14);
            dgvDesignation.Margin = new Padding(4);
            dgvDesignation.Name = "dgvDesignation";
            dgvDesignation.RowHeadersWidth = 51;
            dgvDesignation.Size = new Size(805, 335);
            dgvDesignation.TabIndex = 11;
            dgvDesignation.CellClick += dgvDesignation_CellClick;
            // 
            // txtDesignationName
            // 
            txtDesignationName.Location = new Point(269, 82);
            txtDesignationName.Margin = new Padding(4);
            txtDesignationName.Name = "txtDesignationName";
            txtDesignationName.Size = new Size(183, 31);
            txtDesignationName.TabIndex = 4;
            // 
            // txtDesignationID
            // 
            txtDesignationID.Location = new Point(269, 31);
            txtDesignationID.Margin = new Padding(4);
            txtDesignationID.Name = "txtDesignationID";
            txtDesignationID.Size = new Size(183, 31);
            txtDesignationID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 129);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 30);
            label6.TabIndex = 2;
            label6.Text = "Department:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 81);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(203, 30);
            label5.TabIndex = 1;
            label5.Text = "Designation Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 0;
            label4.Text = "Designation ID:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tcDeptDesign);
            groupBox1.Location = new Point(25, 27);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1300, 720);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Department & Designation";
            // 
            // DepartmentDesignationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 591);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "DepartmentDesignationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department & Designation Management";
            Load += DepartmentDesignationForm_Load;
            tcDeptDesign.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesignation).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button btnDeleteDept;
        private Button btnAddDept;
        private TabControl tcDeptDesign;
        private TabPage tabPage1;
        private DataGridView dgvDepartment;
        private TextBox txtDescription;
        private TextBox txtDeptName;
        private TextBox txtDeptId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private ComboBox cmbDepartmentDesignation;
        private DataGridView dgvDesignation;
        private TextBox txtDesignationName;
        private TextBox txtDesignationID;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtDescriptionDesignation;
        private Label label7;
        private Button btnClearDesignation;
        private Button btnDeleteDesignation;
        private Button btnUpdateDesignation;
        private Button btnAddDesignation;
        private Button button1;
    }
}