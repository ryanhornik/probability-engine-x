namespace ProbToExcelRebuild.Forms
{
    partial class SelectColumnsAverageNewHireSalaries
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
            this.averageSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearHiredTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataStartTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averageSalaryTextBox
            // 
            this.averageSalaryTextBox.Location = new System.Drawing.Point(12, 25);
            this.averageSalaryTextBox.Name = "averageSalaryTextBox";
            this.averageSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageSalaryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average Salary Column";
            // 
            // yearHiredTextBox
            // 
            this.yearHiredTextBox.Location = new System.Drawing.Point(142, 25);
            this.yearHiredTextBox.Name = "yearHiredTextBox";
            this.yearHiredTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearHiredTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year Hired Column";
            // 
            // departmentIDTextBox
            // 
            this.departmentIDTextBox.Location = new System.Drawing.Point(12, 72);
            this.departmentIDTextBox.Name = "departmentIDTextBox";
            this.departmentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentIDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department ID Column";
            // 
            // dataStartTextBox
            // 
            this.dataStartTextBox.Location = new System.Drawing.Point(142, 72);
            this.dataStartTextBox.Name = "dataStartTextBox";
            this.dataStartTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataStartTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Row With Data";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(37, 98);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(142, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SelectColumnsAverageNewHireSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 139);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearHiredTextBox);
            this.Controls.Add(this.dataStartTextBox);
            this.Controls.Add(this.departmentIDTextBox);
            this.Controls.Add(this.averageSalaryTextBox);
            this.Name = "SelectColumnsAverageNewHireSalaries";
            this.Text = "Select Columns";
            this.Load += new System.EventHandler(this.SelectColumnsAverageNewHireSalaries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox averageSalaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearHiredTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataStartTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}