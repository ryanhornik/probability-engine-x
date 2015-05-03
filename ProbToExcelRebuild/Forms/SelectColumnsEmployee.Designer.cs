namespace ProbToExcelRebuild.Forms
{
    partial class SelectColumnsEmployee
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
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.dataRowTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.uniTextBox = new System.Windows.Forms.TextBox();
            this.unilabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Location = new System.Drawing.Point(12, 28);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTitleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Title Column";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(268, 28);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Salary Column";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(142, 28);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentTextBox.TabIndex = 0;
            // 
            // dataRowTextBox
            // 
            this.dataRowTextBox.Location = new System.Drawing.Point(142, 75);
            this.dataRowTextBox.Name = "dataRowTextBox";
            this.dataRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataRowTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department ID Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Row Containing Data";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(105, 114);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseMnemonic = false;
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(209, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseMnemonic = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // uniTextBox
            // 
            this.uniTextBox.Location = new System.Drawing.Point(15, 75);
            this.uniTextBox.Name = "uniTextBox";
            this.uniTextBox.Size = new System.Drawing.Size(100, 20);
            this.uniTextBox.TabIndex = 0;
            // 
            // unilabel
            // 
            this.unilabel.AutoSize = true;
            this.unilabel.Location = new System.Drawing.Point(12, 59);
            this.unilabel.Name = "unilabel";
            this.unilabel.Size = new System.Drawing.Size(91, 13);
            this.unilabel.TabIndex = 1;
            this.unilabel.Text = "University Column";
            // 
            // SelectColumnsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 149);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.unilabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uniTextBox);
            this.Controls.Add(this.dataRowTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.jobTitleTextBox);
            this.Name = "SelectColumnsEmployee";
            this.Text = "Select Columns";
            this.Load += new System.EventHandler(this.SelectColumns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox dataRowTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox uniTextBox;
        private System.Windows.Forms.Label unilabel;
    }
}