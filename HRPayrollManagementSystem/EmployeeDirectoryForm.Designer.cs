namespace HRPayrollManagementSystem
{
    partial class EmployeeDirectoryForm
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
            btnSearch = new Button();
            btnView = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbDepartment = new ComboBox();
            cmbStatus = new ComboBox();
            cmbDesignation = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dgvEmployees = new DataGridView();
            btnRefresh = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(808, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Bottom;
            btnView.Location = new Point(87, 409);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom;
            btnEdit.Location = new Point(245, 409);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.Location = new Point(428, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 27);
            txtSearch.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 36);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 8;
            label2.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(245, 68);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 10;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(614, 68);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 11;
            // 
            // cmbDesignation
            // 
            cmbDesignation.FormattingEnabled = true;
            cmbDesignation.Location = new Point(437, 68);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(151, 28);
            cmbDesignation.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 36);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 13;
            label3.Text = "Designation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 36);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 14;
            label4.Text = "Status:";
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(4, 129);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(909, 249);
            dgvEmployees.TabIndex = 15;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Location = new Point(750, 409);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 4);
            label5.Name = "label5";
            label5.Size = new Size(190, 28);
            label5.TabIndex = 17;
            label5.Text = "Employee Directory";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(label5);
            Controls.Add(btnRefresh);
            Controls.Add(dgvEmployees);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbDesignation);
            Controls.Add(cmbStatus);
            Controls.Add(cmbDepartment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(btnSearch);
            this.Name = "EmployeeDirectoryForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Employee Directory";
            this.Load += EmployeeDirectoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Button btnView;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private ComboBox cmbDepartment;
        private ComboBox cmbStatus;
        private ComboBox cmbDesignation;
        private Label label3;
        private Label label4;
        private DataGridView dgvEmployees;
        private Button btnRefresh;
        private Label label5;
    }
}