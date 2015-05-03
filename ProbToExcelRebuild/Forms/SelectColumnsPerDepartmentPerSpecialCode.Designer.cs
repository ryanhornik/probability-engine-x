namespace ProbToExcelRebuild.Forms
{
    partial class SelectColumnsPerDepartmentPerSpecialCode
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
            this.specialtyCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deptIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.averageSalaryTextBox = new System.Windows.Forms.TextBox();
            this.dataRowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // specialtyCodeTextBox
            // 
            this.specialtyCodeTextBox.Location = new System.Drawing.Point(13, 34);
            this.specialtyCodeTextBox.Name = "specialtyCodeTextBox";
            this.specialtyCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.specialtyCodeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Specialty Code Column";
            // 
            // deptIDTextBox
            // 
            this.deptIDTextBox.Location = new System.Drawing.Point(140, 34);
            this.deptIDTextBox.Name = "deptIDTextBox";
            this.deptIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.deptIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department ID Column";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(12, 84);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 2;
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Location = new System.Drawing.Point(139, 84);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTitleTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code Weight Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Job Title Column";
            // 
            // averageSalaryTextBox
            // 
            this.averageSalaryTextBox.Location = new System.Drawing.Point(13, 138);
            this.averageSalaryTextBox.Name = "averageSalaryTextBox";
            this.averageSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageSalaryTextBox.TabIndex = 4;
            // 
            // dataRowTextBox
            // 
            this.dataRowTextBox.Location = new System.Drawing.Point(140, 138);
            this.dataRowTextBox.Name = "dataRowTextBox";
            this.dataRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataRowTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Average Salary Column";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Row With Data";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(37, 173);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(139, 173);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SelectColumnsPerDepartmentPerSpecialCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 213);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataRowTextBox);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(this.deptIDTextBox);
            this.Controls.Add(this.averageSalaryTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.specialtyCodeTextBox);
            this.Name = "SelectColumnsPerDepartmentPerSpecialCode";
            this.Text = "Select Columns";
            this.Load += new System.EventHandler(this.SelectColumnsPerDepartmentPerSpecialCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox specialtyCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox averageSalaryTextBox;
        private System.Windows.Forms.TextBox dataRowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}