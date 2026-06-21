namespace HRPayrollManagementSystem
{
    partial class AttendanceManagementForm
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
            btnSaveAttendance = new Button();
            dataGridView1 = new DataGridView();
            btnViewHistory = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimeAttendance = new DateTimePicker();
            cmbDepartment = new ComboBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSaveAttendance
            // 
            btnSaveAttendance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAttendance.BackColor = Color.Green;
            btnSaveAttendance.ForeColor = SystemColors.ButtonHighlight;
            btnSaveAttendance.Location = new Point(300, 452);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(160, 35);
            btnSaveAttendance.TabIndex = 0;
            btnSaveAttendance.Text = "Save Attendance";
            btnSaveAttendance.UseVisualStyleBackColor = false;
            btnSaveAttendance.Click += btnSaveAttendance_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(915, 326);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnViewHistory.BackColor = SystemColors.ControlLight;
            btnViewHistory.Location = new Point(500, 452);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(131, 35);
            btnViewHistory.TabIndex = 3;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = false;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 4;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(243, 28);
            label2.TabIndex = 5;
            label2.Text = "Attendance Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 32);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 6;
            label3.Text = "Department:";
            // 
            // dateTimeAttendance
            // 
            dateTimeAttendance.Location = new Point(86, 58);
            dateTimeAttendance.Name = "dateTimeAttendance";
            dateTimeAttendance.Size = new Size(250, 27);
            dateTimeAttendance.TabIndex = 7;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(506, 67);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 8;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoad.BackColor = SystemColors.HotTrack;
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(744, 66);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // AttendanceManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 503);
            Controls.Add(btnLoad);
            Controls.Add(cmbDepartment);
            Controls.Add(dateTimeAttendance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnViewHistory);
            Controls.Add(dataGridView1);
            Controls.Add(btnSaveAttendance);
            this.Name = "AttendanceManagementForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Attendance Management";
            this.Load += AttendanceManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveAttendance;
        private DataGridView dataGridView1;
        private Button btnViewHistory;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimeAttendance;
        private ComboBox cmbDepartment;
        private Button btnLoad;
    }
}
