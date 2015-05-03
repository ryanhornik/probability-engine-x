namespace ProbToExcelRebuild.Forms
{
    partial class ManualEntryEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualEntryEmployee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UniversityComboBox = new System.Windows.Forms.ComboBox();
            this.UniversityLabel = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.JobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.University = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UniversityComboBox);
            this.groupBox1.Controls.Add(this.UniversityLabel);
            this.groupBox1.Controls.Add(this.SalaryTextBox);
            this.groupBox1.Controls.Add(this.DepartmentComboBox);
            this.groupBox1.Controls.Add(this.JobTitleComboBox);
            this.groupBox1.Controls.Add(this.SalaryLabel);
            this.groupBox1.Controls.Add(this.DepartmentLabel);
            this.groupBox1.Controls.Add(this.JobTitleLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EmployeeData";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // UniversityComboBox
            // 
            this.UniversityComboBox.FormattingEnabled = true;
            this.UniversityComboBox.Location = new System.Drawing.Point(106, 74);
            this.UniversityComboBox.Name = "UniversityComboBox";
            this.UniversityComboBox.Size = new System.Drawing.Size(148, 21);
            this.UniversityComboBox.TabIndex = 1;
            // 
            // UniversityLabel
            // 
            this.UniversityLabel.AutoSize = true;
            this.UniversityLabel.Location = new System.Drawing.Point(7, 74);
            this.UniversityLabel.Name = "UniversityLabel";
            this.UniversityLabel.Size = new System.Drawing.Size(53, 13);
            this.UniversityLabel.TabIndex = 6;
            this.UniversityLabel.Text = "University";
            this.UniversityLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(106, 151);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(148, 20);
            this.SalaryTextBox.TabIndex = 3;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(106, 112);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(148, 21);
            this.DepartmentComboBox.TabIndex = 2;
            // 
            // JobTitleComboBox
            // 
            this.JobTitleComboBox.FormattingEnabled = true;
            this.JobTitleComboBox.Location = new System.Drawing.Point(106, 33);
            this.JobTitleComboBox.Name = "JobTitleComboBox";
            this.JobTitleComboBox.Size = new System.Drawing.Size(148, 21);
            this.JobTitleComboBox.TabIndex = 0;
            this.JobTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.JobTitleComboBox_SelectedIndexChanged);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(7, 151);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(36, 13);
            this.SalaryLabel.TabIndex = 2;
            this.SalaryLabel.Text = "Salary";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(6, 115);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 1;
            this.DepartmentLabel.Text = "Department";
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(7, 33);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(47, 13);
            this.JobTitleLabel.TabIndex = 0;
            this.JobTitleLabel.Text = "Job Title";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(285, 449);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(159, 42);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(450, 449);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 42);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(615, 449);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(159, 42);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmployeeGridView);
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 382);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobTitle,
            this.University,
            this.Department,
            this.Salary});
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.Location = new System.Drawing.Point(3, 16);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.Size = new System.Drawing.Size(596, 363);
            this.EmployeeGridView.TabIndex = 7;
            // 
            // JobTitle
            // 
            this.JobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobTitle.HeaderText = "Job Title";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            // 
            // University
            // 
            this.University.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.University.HeaderText = "University";
            this.University.Name = "University";
            this.University.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // ManualEntryEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManualEntryEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.ManualEntryEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label JobTitleLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label UniversityLabel;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox JobTitleComboBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.ComboBox UniversityComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn University;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}