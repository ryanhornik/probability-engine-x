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
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(73, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 248);
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
            this.UniversityComboBox.TabIndex = 7;
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
            this.SalaryTextBox.TabIndex = 5;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(106, 112);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(148, 21);
            this.DepartmentComboBox.TabIndex = 4;
            // 
            // JobTitleComboBox
            // 
            this.JobTitleComboBox.FormattingEnabled = true;
            this.JobTitleComboBox.Location = new System.Drawing.Point(106, 33);
            this.JobTitleComboBox.Name = "JobTitleComboBox";
            this.JobTitleComboBox.Size = new System.Drawing.Size(148, 21);
            this.JobTitleComboBox.TabIndex = 3;
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
            this.EnterButton.Location = new System.Drawing.Point(12, 410);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(159, 42);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(177, 410);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 42);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(342, 410);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(159, 42);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ManualEntryEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 503);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManualEntryEmployee";
            this.Text = "ManualEntryEmployee";
            this.Load += new System.EventHandler(this.ManualEntryEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}