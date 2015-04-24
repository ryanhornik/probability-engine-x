namespace ProbabilityToExcel
{
    partial class ManualEntry
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.JobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Salaries = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.RichTextBox();
            this.DepartmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.Salaries.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(98, 340);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(147, 39);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(526, 340);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 39);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(317, 340);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(136, 39);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job Title";
            // 
            // JobTitleComboBox
            // 
            this.JobTitleComboBox.FormattingEnabled = true;
            this.JobTitleComboBox.Location = new System.Drawing.Point(144, 28);
            this.JobTitleComboBox.Name = "JobTitleComboBox";
            this.JobTitleComboBox.Size = new System.Drawing.Size(189, 21);
            this.JobTitleComboBox.TabIndex = 10;
            this.JobTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.JobTitleComboBox_SelectedIndexChanged);

            //this.JobTitleComboBox_SelectedIndexChanged
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepartmentIDComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.JobTitleComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter UH Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Salaries
            // 
            this.Salaries.Controls.Add(this.label5);
            this.Salaries.Controls.Add(this.SalaryBox);
            this.Salaries.Location = new System.Drawing.Point(399, 12);
            this.Salaries.Name = "Salaries";
            this.Salaries.Size = new System.Drawing.Size(277, 247);
            this.Salaries.TabIndex = 15;
            this.Salaries.TabStop = false;
            this.Salaries.Text = "UH Salaries";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "*One Salary per Line*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(18, 28);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(237, 173);
            this.SalaryBox.TabIndex = 0;
            this.SalaryBox.Text = "";
            // 
            // DepartmentIDComboBox
            // 
            this.DepartmentIDComboBox.FormattingEnabled = true;
            this.DepartmentIDComboBox.Location = new System.Drawing.Point(144, 57);
            this.DepartmentIDComboBox.Name = "DepartmentIDComboBox";
            this.DepartmentIDComboBox.Size = new System.Drawing.Size(189, 21);
            this.DepartmentIDComboBox.TabIndex = 13;
            this.DepartmentIDComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentIDComboBox_SelectedIndexChanged);
            // 
            // ManualEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 391);
            this.Controls.Add(this.Salaries);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EnterButton);
            this.Name = "ManualEntry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Manual UH Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Salaries.ResumeLayout(false);
            this.Salaries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox JobTitleComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Salaries;
        private System.Windows.Forms.RichTextBox SalaryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DepartmentIDComboBox;
    }
}