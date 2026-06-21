namespace HRPayrollManagementSystem
{
    partial class ReportViewerForm
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
            grpReportsType = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            grpFilters = new GroupBox();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            cmbYear = new ComboBox();
            cmbMonth = new ComboBox();
            cmbDepartment = new ComboBox();
            cmbEmployee = new ComboBox();
            lblToDate = new Label();
            lblFromDate = new Label();
            lblYear = new Label();
            lblMonth = new Label();
            lblDepartment = new Label();
            lblEmployeeID = new Label();
            grpReportPreview = new GroupBox();
            dgvDesignation = new DataGridView();
            btnPDF = new Button();
            btnGenerate = new Button();
            grpReportsType.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            grpFilters.SuspendLayout();
            grpReportPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesignation).BeginInit();
            SuspendLayout();
            // 
            // grpReportsType
            // 
            grpReportsType.Controls.Add(flowLayoutPanel1);
            grpReportsType.ForeColor = Color.Navy;
            grpReportsType.Location = new Point(13, 23);
            grpReportsType.Margin = new Padding(4, 5, 4, 5);
            grpReportsType.Name = "grpReportsType";
            grpReportsType.Padding = new Padding(4, 5, 4, 5);
            grpReportsType.Size = new Size(325, 395);
            grpReportsType.TabIndex = 1;
            grpReportsType.TabStop = false;
            grpReportsType.Text = "Reports Type";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Location = new Point(7, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 310);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(297, 54);
            button1.TabIndex = 0;
            button1.Text = "Employee List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 63);
            button2.Name = "button2";
            button2.Size = new Size(297, 54);
            button2.TabIndex = 1;
            button2.Text = "Attendance Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 123);
            button3.Name = "button3";
            button3.Size = new Size(297, 54);
            button3.TabIndex = 2;
            button3.Text = "Leave Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 183);
            button5.Name = "button5";
            button5.Size = new Size(297, 54);
            button5.TabIndex = 3;
            button5.Text = "Payroll Summary";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 243);
            button6.Name = "button6";
            button6.Size = new Size(297, 54);
            button6.TabIndex = 4;
            button6.Text = "Payslip Report";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // grpFilters
            // 
            grpFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFilters.Controls.Add(dtpTo);
            grpFilters.Controls.Add(dtpFrom);
            grpFilters.Controls.Add(cmbYear);
            grpFilters.Controls.Add(cmbMonth);
            grpFilters.Controls.Add(cmbDepartment);
            grpFilters.Controls.Add(cmbEmployee);
            grpFilters.Controls.Add(lblToDate);
            grpFilters.Controls.Add(lblFromDate);
            grpFilters.Controls.Add(lblYear);
            grpFilters.Controls.Add(lblMonth);
            grpFilters.Controls.Add(lblDepartment);
            grpFilters.Controls.Add(lblEmployeeID);
            grpFilters.ForeColor = Color.Navy;
            grpFilters.Location = new Point(362, 23);
            grpFilters.Margin = new Padding(4, 5, 4, 5);
            grpFilters.Name = "grpFilters";
            grpFilters.Padding = new Padding(4, 5, 4, 5);
            grpFilters.Size = new Size(1052, 154);
            grpFilters.TabIndex = 2;
            grpFilters.TabStop = false;
            grpFilters.Text = "Filters";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(640, 96);
            dtpTo.Margin = new Padding(4, 5, 4, 5);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(256, 31);
            dtpTo.TabIndex = 11;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(640, 34);
            dtpFrom.Margin = new Padding(4, 5, 4, 5);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(256, 31);
            dtpFrom.TabIndex = 10;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026" });
            cmbYear.Location = new Point(341, 94);
            cmbYear.Margin = new Padding(4, 5, 4, 5);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(169, 33);
            cmbYear.TabIndex = 9;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonth.Location = new Point(341, 38);
            cmbMonth.Margin = new Padding(4, 5, 4, 5);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(169, 33);
            cmbMonth.TabIndex = 8;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "--All--", "HR", "Finance", "IT", "Sales" });
            cmbDepartment.Location = new Point(140, 94);
            cmbDepartment.Margin = new Padding(4, 5, 4, 5);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(92, 33);
            cmbDepartment.TabIndex = 7;
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Items.AddRange(new object[] { "--All--" });
            cmbEmployee.Location = new Point(140, 40);
            cmbEmployee.Margin = new Padding(4, 5, 4, 5);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(92, 33);
            cmbEmployee.TabIndex = 6;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.ForeColor = Color.Black;
            lblToDate.Location = new Point(532, 100);
            lblToDate.Margin = new Padding(4, 0, 4, 0);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(76, 25);
            lblToDate.TabIndex = 5;
            lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.ForeColor = Color.Black;
            lblFromDate.Location = new Point(532, 38);
            lblFromDate.Margin = new Padding(4, 0, 4, 0);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(100, 25);
            lblFromDate.TabIndex = 4;
            lblFromDate.Text = "From Date:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.ForeColor = Color.Black;
            lblYear.Location = new Point(262, 99);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(48, 25);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year:";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.ForeColor = Color.Black;
            lblMonth.Location = new Point(262, 40);
            lblMonth.Margin = new Padding(4, 0, 4, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(69, 25);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "Month:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.ForeColor = Color.Black;
            lblDepartment.Location = new Point(14, 94);
            lblDepartment.Margin = new Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(111, 25);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Department:";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.ForeColor = Color.Black;
            lblEmployeeID.Location = new Point(14, 45);
            lblEmployeeID.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(117, 25);
            lblEmployeeID.TabIndex = 0;
            lblEmployeeID.Text = "Employee ID:";
            // 
            // grpReportPreview
            // 
            grpReportPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpReportPreview.Controls.Add(dgvDesignation);
            grpReportPreview.ForeColor = Color.Navy;
            grpReportPreview.Location = new Point(362, 187);
            grpReportPreview.Margin = new Padding(4, 5, 4, 5);
            grpReportPreview.Name = "grpReportPreview";
            grpReportPreview.Padding = new Padding(4, 5, 4, 5);
            grpReportPreview.Size = new Size(1052, 264);
            grpReportPreview.TabIndex = 3;
            grpReportPreview.TabStop = false;
            grpReportPreview.Text = "Report Preview";
            grpReportPreview.Enter += grpReportPreview_Enter;
            // 
            // dgvDesignation
            // 
            dgvDesignation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDesignation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesignation.Location = new Point(17, 33);
            dgvDesignation.Margin = new Padding(4);
            dgvDesignation.Name = "dgvDesignation";
            dgvDesignation.RowHeadersWidth = 51;
            dgvDesignation.Size = new Size(1015, 222);
            dgvDesignation.TabIndex = 12;
            dgvDesignation.Location = new Point(17, 33);
            dgvDesignation.Margin = new Padding(4);
            dgvDesignation.Name = "dgvDesignation";
            dgvDesignation.RowHeadersWidth = 51;
            dgvDesignation.Size = new Size(1015, 222);
            dgvDesignation.TabIndex = 12;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDF.BackColor = Color.Red;
            btnPDF.ForeColor = Color.White;
            btnPDF.Location = new Point(1171, 461);
            btnPDF.Margin = new Padding(4, 5, 4, 5);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(201, 69);
            btnPDF.TabIndex = 10;
            btnPDF.Text = "Export CSV";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerate.BackColor = Color.Blue;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(76, 440);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(201, 69);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // ReportViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 551);
            Controls.Add(btnPDF);
            Controls.Add(btnGenerate);
            Controls.Add(grpReportPreview);
            Controls.Add(grpFilters);
            Controls.Add(grpReportsType);
            Name = "ReportViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Viewer";
            Load += ReportViewerForm_Load;
            grpReportsType.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            grpFilters.ResumeLayout(false);
            grpFilters.PerformLayout();
            grpReportPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDesignation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpReportsType;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private GroupBox grpFilters;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private ComboBox cmbYear;
        private ComboBox cmbMonth;
        private ComboBox cmbDepartment;
        private ComboBox cmbEmployee;
        private Label lblToDate;
        private Label lblFromDate;
        private Label lblYear;
        private Label lblMonth;
        private Label lblDepartment;
        private Label lblEmployeeID;
        private GroupBox grpReportPreview;
        private DataGridView dgvDesignation;
        private Button btnPDF;
        private Button btnGenerate;
    }
}