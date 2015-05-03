namespace ProbToExcelRebuild.Forms
{
    partial class SelectUniversity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUniversity));
            this.UniversityDropDown = new System.Windows.Forms.ComboBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fromFileCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UniversityDropDown
            // 
            this.UniversityDropDown.BackColor = System.Drawing.SystemColors.Window;
            this.UniversityDropDown.FormattingEnabled = true;
            this.UniversityDropDown.Location = new System.Drawing.Point(107, 48);
            this.UniversityDropDown.Name = "UniversityDropDown";
            this.UniversityDropDown.Size = new System.Drawing.Size(248, 21);
            this.UniversityDropDown.TabIndex = 2;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(99, 81);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(180, 81);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select or enter university to associate with this data";
            // 
            // fromFileCheckBox
            // 
            this.fromFileCheckBox.AutoSize = true;
            this.fromFileCheckBox.Location = new System.Drawing.Point(-1, 52);
            this.fromFileCheckBox.Name = "fromFileCheckBox";
            this.fromFileCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromFileCheckBox.Size = new System.Drawing.Size(88, 17);
            this.fromFileCheckBox.TabIndex = 1;
            this.fromFileCheckBox.Text = "Get From File";
            this.fromFileCheckBox.UseVisualStyleBackColor = true;
            this.fromFileCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SelectUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 116);
            this.Controls.Add(this.fromFileCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.UniversityDropDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectUniversity";
            this.Text = "Select University";
            this.Load += new System.EventHandler(this.SelectUniversity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UniversityDropDown;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fromFileCheckBox;
    }
}