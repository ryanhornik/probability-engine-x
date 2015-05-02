namespace ProbToExcelRebuild.Forms
{
    partial class SpecialCodeManualEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialCodeManualEntry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UniversityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AvgTierSalTextBox = new System.Windows.Forms.TextBox();
            this.SpecialtyCodeTextBox = new System.Windows.Forms.TextBox();
            this.JobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.EnterButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpecialtyGridView = new System.Windows.Forms.DataGridView();
            this.SpecialtyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UniversityComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AvgTierSalTextBox);
            this.groupBox1.Controls.Add(this.SpecialtyCodeTextBox);
            this.groupBox1.Controls.Add(this.JobTitleComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.JobTitleLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specialty Data Entry";
            // 
            // UniversityComboBox
            // 
            this.UniversityComboBox.FormattingEnabled = true;
            this.UniversityComboBox.Location = new System.Drawing.Point(106, 229);
            this.UniversityComboBox.Name = "UniversityComboBox";
            this.UniversityComboBox.Size = new System.Drawing.Size(164, 21);
            this.UniversityComboBox.TabIndex = 16;
            this.UniversityComboBox.SelectedIndexChanged += new System.EventHandler(this.UniversityComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "University";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Weight";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AvgTierSalTextBox
            // 
            this.AvgTierSalTextBox.Location = new System.Drawing.Point(106, 143);
            this.AvgTierSalTextBox.Name = "AvgTierSalTextBox";
            this.AvgTierSalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AvgTierSalTextBox.Size = new System.Drawing.Size(164, 20);
            this.AvgTierSalTextBox.TabIndex = 10;
            // 
            // SpecialtyCodeTextBox
            // 
            this.SpecialtyCodeTextBox.Location = new System.Drawing.Point(106, 29);
            this.SpecialtyCodeTextBox.Name = "SpecialtyCodeTextBox";
            this.SpecialtyCodeTextBox.Size = new System.Drawing.Size(164, 20);
            this.SpecialtyCodeTextBox.TabIndex = 9;
            // 
            // JobTitleComboBox
            // 
            this.JobTitleComboBox.FormattingEnabled = true;
            this.JobTitleComboBox.Location = new System.Drawing.Point(106, 69);
            this.JobTitleComboBox.Name = "JobTitleComboBox";
            this.JobTitleComboBox.Size = new System.Drawing.Size(164, 21);
            this.JobTitleComboBox.TabIndex = 5;
            this.JobTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.JobTitleComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Avg Tier 1 Salary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(7, 69);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(47, 13);
            this.JobTitleLabel.TabIndex = 3;
            this.JobTitleLabel.Text = "Job Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specialty Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(284, 479);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(104, 34);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(459, 479);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(104, 34);
            this.CancleButton.TabIndex = 2;
            this.CancleButton.Text = "Cancel";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpecialtyGridView);
            this.groupBox2.Location = new System.Drawing.Point(465, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 282);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Table";
            // 
            // SpecialtyGridView
            // 
            this.SpecialtyGridView.AllowUserToAddRows = false;
            this.SpecialtyGridView.AllowUserToDeleteRows = false;
            this.SpecialtyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecialtyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecialtyCode,
            this.JobTitle,
            this.AvgSalary});
            this.SpecialtyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecialtyGridView.Location = new System.Drawing.Point(3, 16);
            this.SpecialtyGridView.Name = "SpecialtyGridView";
            this.SpecialtyGridView.ReadOnly = true;
            this.SpecialtyGridView.Size = new System.Drawing.Size(391, 263);
            this.SpecialtyGridView.TabIndex = 0;
            this.SpecialtyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecialtyGridView_CellContentClick);
            // 
            // SpecialtyCode
            // 
            this.SpecialtyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpecialtyCode.HeaderText = "Specialty Code";
            this.SpecialtyCode.Name = "SpecialtyCode";
            this.SpecialtyCode.ReadOnly = true;
            // 
            // JobTitle
            // 
            this.JobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobTitle.HeaderText = "Job Title";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            // 
            // AvgSalary
            // 
            this.AvgSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AvgSalary.HeaderText = "Avg Tier 1 Salary";
            this.AvgSalary.Name = "AvgSalary";
            this.AvgSalary.ReadOnly = true;
            // 
            // SpecialCodeManualEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpecialCodeManualEntry";
            this.Text = "Special Code";
            this.Load += new System.EventHandler(this.SpecialCodeManualEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox JobTitleComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label JobTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpecialtyCodeTextBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox AvgTierSalTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView SpecialtyGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UniversityComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgSalary;
    }
}