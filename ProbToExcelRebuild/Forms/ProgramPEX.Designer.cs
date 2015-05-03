using System.Runtime.Remoting.Channels;

namespace ProbToExcelRebuild.Forms
{
    partial class ProgramPEX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramPEX));
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompilerBox = new System.Windows.Forms.TextBox();
            this.UniversityList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUniversity = new System.Windows.Forms.Button();
            this.JobTitleList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTitle = new System.Windows.Forms.Button();
            this.DepartmentList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDepartment = new System.Windows.Forms.Button();
            this.SpecialFunctionList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSpecial = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomFunctionList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCustom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DebugTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(221, 325);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 37);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompilerBox
            // 
            this.CompilerBox.Location = new System.Drawing.Point(19, 284);
            this.CompilerBox.Name = "CompilerBox";
            this.CompilerBox.Size = new System.Drawing.Size(531, 20);
            this.CompilerBox.TabIndex = 5;
            // 
            // UniversityList
            // 
            this.UniversityList.FormattingEnabled = true;
            this.UniversityList.Location = new System.Drawing.Point(720, 291);
            this.UniversityList.Name = "UniversityList";
            this.UniversityList.Size = new System.Drawing.Size(121, 21);
            this.UniversityList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "University";
            // 
            // AddUniversity
            // 
            this.AddUniversity.Location = new System.Drawing.Point(618, 290);
            this.AddUniversity.Name = "AddUniversity";
            this.AddUniversity.Size = new System.Drawing.Size(96, 23);
            this.AddUniversity.TabIndex = 8;
            this.AddUniversity.Text = "Add To Function";
            this.AddUniversity.UseVisualStyleBackColor = true;
            this.AddUniversity.Click += new System.EventHandler(this.AddUniversity_Click);
            // 
            // JobTitleList
            // 
            this.JobTitleList.FormattingEnabled = true;
            this.JobTitleList.Location = new System.Drawing.Point(720, 183);
            this.JobTitleList.Name = "JobTitleList";
            this.JobTitleList.Size = new System.Drawing.Size(121, 21);
            this.JobTitleList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Job Title";
            // 
            // AddTitle
            // 
            this.AddTitle.Location = new System.Drawing.Point(618, 182);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(96, 23);
            this.AddTitle.TabIndex = 8;
            this.AddTitle.Text = "Add To Function";
            this.AddTitle.UseVisualStyleBackColor = true;
            this.AddTitle.Click += new System.EventHandler(this.AddTitle_Click);
            // 
            // DepartmentList
            // 
            this.DepartmentList.FormattingEnabled = true;
            this.DepartmentList.Location = new System.Drawing.Point(720, 236);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.Size = new System.Drawing.Size(121, 21);
            this.DepartmentList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Department";
            // 
            // AddDepartment
            // 
            this.AddDepartment.Location = new System.Drawing.Point(618, 235);
            this.AddDepartment.Name = "AddDepartment";
            this.AddDepartment.Size = new System.Drawing.Size(96, 23);
            this.AddDepartment.TabIndex = 8;
            this.AddDepartment.Text = "Add To Function";
            this.AddDepartment.UseVisualStyleBackColor = true;
            this.AddDepartment.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // SpecialFunctionList
            // 
            this.SpecialFunctionList.FormattingEnabled = true;
            this.SpecialFunctionList.Location = new System.Drawing.Point(720, 128);
            this.SpecialFunctionList.Name = "SpecialFunctionList";
            this.SpecialFunctionList.Size = new System.Drawing.Size(121, 21);
            this.SpecialFunctionList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Special Functions";
            // 
            // AddSpecial
            // 
            this.AddSpecial.Location = new System.Drawing.Point(618, 127);
            this.AddSpecial.Name = "AddSpecial";
            this.AddSpecial.Size = new System.Drawing.Size(96, 23);
            this.AddSpecial.TabIndex = 8;
            this.AddSpecial.Text = "Add To Function";
            this.AddSpecial.UseVisualStyleBackColor = true;
            this.AddSpecial.Click += new System.EventHandler(this.AddSpecial_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(388, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 37);
            this.button7.TabIndex = 4;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter your custom function here:";
            // 
            // CustomFunctionList
            // 
            this.CustomFunctionList.FormattingEnabled = true;
            this.CustomFunctionList.Location = new System.Drawing.Point(720, 78);
            this.CustomFunctionList.Name = "CustomFunctionList";
            this.CustomFunctionList.Size = new System.Drawing.Size(121, 21);
            this.CustomFunctionList.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saved Functions";
            // 
            // AddCustom
            // 
            this.AddCustom.Location = new System.Drawing.Point(618, 77);
            this.AddCustom.Name = "AddCustom";
            this.AddCustom.Size = new System.Drawing.Size(96, 23);
            this.AddCustom.TabIndex = 8;
            this.AddCustom.Text = "Add To Function";
            this.AddCustom.UseVisualStyleBackColor = true;
            this.AddCustom.Click += new System.EventHandler(this.AddCustom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(574, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 313);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function Helpers";
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugTextBox.Location = new System.Drawing.Point(19, 37);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.ReadOnly = true;
            this.DebugTextBox.Size = new System.Drawing.Size(531, 194);
            this.DebugTextBox.TabIndex = 0;
            this.DebugTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Output";
            // 
            // ProgramPEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 374);
            this.Controls.Add(this.DebugTextBox);
            this.Controls.Add(this.AddDepartment);
            this.Controls.Add(this.AddCustom);
            this.Controls.Add(this.AddSpecial);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.AddUniversity);
            this.Controls.Add(this.DepartmentList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomFunctionList);
            this.Controls.Add(this.SpecialFunctionList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JobTitleList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UniversityList);
            this.Controls.Add(this.CompilerBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramPEX";
            this.Text = "Custom Functions";
            this.Load += new System.EventHandler(this.ProgramPEX_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CompilerBox;
        private System.Windows.Forms.ComboBox UniversityList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUniversity;
        private System.Windows.Forms.ComboBox JobTitleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTitle;
        private System.Windows.Forms.ComboBox DepartmentList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddDepartment;
        private System.Windows.Forms.ComboBox SpecialFunctionList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddSpecial;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CustomFunctionList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCustom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox DebugTextBox;
        private System.Windows.Forms.Label label7;
    }
}