namespace ProbabilityToExcel
{
    partial class SelectAverageCalculationDialog
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.RightButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Mean",
            "First Quartile",
            "Median",
            "Third Quartile"});
            this.listBox1.Location = new System.Drawing.Point(36, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Averages to Calculate";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "University",
            "Job Title",
            "Department"});
            this.listBox2.Location = new System.Drawing.Point(24, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(183, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 3;
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.RightButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RightButton.Location = new System.Drawing.Point(155, 30);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(18, 18);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "▶";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.UpButton);
            this.groupBox1.Controls.Add(this.DownButton);
            this.groupBox1.Controls.Add(this.LeftButton);
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.RightButton);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Categories to Group By";
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LeftButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LeftButton.Location = new System.Drawing.Point(155, 50);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(18, 18);
            this.LeftButton.TabIndex = 6;
            this.LeftButton.Text = "◀";
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DownButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DownButton.Location = new System.Drawing.Point(155, 90);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(18, 18);
            this.DownButton.TabIndex = 7;
            this.DownButton.Text = "▼";
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            this.UpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.UpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpButton.Location = new System.Drawing.Point(155, 70);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(18, 18);
            this.UpButton.TabIndex = 7;
            this.UpButton.Text = "▲";
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelectAverageCalculationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(354, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectAverageCalculationDialog";
            this.Text = "SelectAverageCalculationDialog";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}