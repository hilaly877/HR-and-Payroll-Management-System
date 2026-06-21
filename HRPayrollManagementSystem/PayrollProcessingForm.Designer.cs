namespace HRPayrollManagementSystem
{
    partial class PayrollProcessingForm
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
            cmbMonth = new ComboBox();
            cmbYear = new ComboBox();
            cmbDept = new ComboBox();
            btnGenerateSlip = new Button();
            btnSave = new Button();
            btnCalculate = new Button();
            lblPayrollStatus = new Label();
            dgvPayroll = new DataGridView();
            btnLoad = new Button();
            cmbPayrollStatus = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbMonth);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(cmbDept);
            groupBox1.Controls.Add(btnGenerateSlip);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(lblPayrollStatus);
            groupBox1.Controls.Add(dgvPayroll);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(cmbPayrollStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 620);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payroll Processing";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(101, 56);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(182, 33);
            cmbMonth.TabIndex = 24;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(354, 56);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(105, 33);
            cmbYear.TabIndex = 23;
            cmbYear.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbDept
            // 
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(616, 56);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(182, 33);
            cmbDept.TabIndex = 22;
            // 
            // btnGenerateSlip
            // 
            btnGenerateSlip.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerateSlip.BackColor = Color.DarkOrchid;
            btnGenerateSlip.FlatStyle = FlatStyle.Flat;
            btnGenerateSlip.ForeColor = Color.White;
            btnGenerateSlip.Location = new Point(745, 493);
            btnGenerateSlip.Margin = new Padding(4, 5, 4, 5);
            btnGenerateSlip.Name = "btnGenerateSlip";
            btnGenerateSlip.Size = new Size(161, 57);
            btnGenerateSlip.TabIndex = 21;
            btnGenerateSlip.Text = "Generate Payslip";
            btnGenerateSlip.UseVisualStyleBackColor = false;
            btnGenerateSlip.Click += btnGenerateSlip_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(556, 495);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 53);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save Payroll";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCalculate.BackColor = Color.MediumBlue;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(354, 496);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(161, 50);
            btnCalculate.TabIndex = 19;
            btnCalculate.Text = "Calculate Payroll";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPayrollStatus
            // 
            lblPayrollStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPayrollStatus.AutoSize = true;
            lblPayrollStatus.ForeColor = Color.Black;
            lblPayrollStatus.Location = new Point(27, 481);
            lblPayrollStatus.Margin = new Padding(4, 0, 4, 0);
            lblPayrollStatus.Name = "lblPayrollStatus";
            lblPayrollStatus.Size = new Size(121, 25);
            lblPayrollStatus.TabIndex = 18;
            lblPayrollStatus.Text = "Payroll Status:";
            // 
            // dgvPayroll
            // 
            dgvPayroll.AllowUserToAddRows = false;
            dgvPayroll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayroll.BackgroundColor = Color.White;
            dgvPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayroll.Location = new Point(27, 107);
            dgvPayroll.Margin = new Padding(4, 5, 4, 5);
            dgvPayroll.Name = "dgvPayroll";
            dgvPayroll.ReadOnly = true;
            dgvPayroll.RowHeadersWidth = 51;
            dgvPayroll.RowTemplate.Height = 24;
            dgvPayroll.Size = new Size(879, 369);
            dgvPayroll.TabIndex = 17;
            dgvPayroll.CellContentClick += dgvPayroll_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoad.BackColor = Color.Blue;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(858, 45);
            btnLoad.Margin = new Padding(4, 5, 4, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(161, 52);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbPayrollStatus
            // 
            cmbPayrollStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbPayrollStatus.FormattingEnabled = true;
            cmbPayrollStatus.Location = new Point(27, 513);
            cmbPayrollStatus.Name = "cmbPayrollStatus";
            cmbPayrollStatus.Size = new Size(182, 33);
            cmbPayrollStatus.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 59);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 4;
            label3.Text = "Department : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Year : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Month : ";
            // 
            // PayrollProcessingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 636);
            Controls.Add(groupBox1);
            Name = "PayrollProcessingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll Processing Management";
            Load += ppf_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbPayrollStatus;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLoad;
        private DataGridView dgvPayroll;
        private Label lblPayrollStatus;
        private Button btnGenerateSlip;
        private Button btnSave;
        private Button btnCalculate;
        private ComboBox cmbMonth;
        private ComboBox cmbYear;
        private ComboBox cmbDept;
    }
}