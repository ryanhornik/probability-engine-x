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
            this.button2 = new System.Windows.Forms.Button();
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
            this.UniversityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UniversityList.FormattingEnabled = true;
            this.UniversityList.ItemHeight = 13;
            this.UniversityList.Location = new System.Drawing.Point(110, 277);
            this.UniversityList.Name = "UniversityList";
            this.UniversityList.Size = new System.Drawing.Size(225, 21);
            this.UniversityList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "University";
            // 
            // AddUniversity
            // 
            this.AddUniversity.Location = new System.Drawing.Point(5, 275);
            this.AddUniversity.Name = "AddUniversity";
            this.AddUniversity.Size = new System.Drawing.Size(100, 25);
            this.AddUniversity.TabIndex = 8;
            this.AddUniversity.Text = "Add To Function";
            this.AddUniversity.UseVisualStyleBackColor = true;
            this.AddUniversity.Click += new System.EventHandler(this.AddUniversity_Click);
            // 
            // JobTitleList
            // 
            this.JobTitleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobTitleList.FormattingEnabled = true;
            this.JobTitleList.ItemHeight = 13;
            this.JobTitleList.Location = new System.Drawing.Point(110, 167);
            this.JobTitleList.Name = "JobTitleList";
            this.JobTitleList.Size = new System.Drawing.Size(225, 21);
            this.JobTitleList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Job Title";
            // 
            // AddTitle
            // 
            this.AddTitle.Location = new System.Drawing.Point(5, 165);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(100, 25);
            this.AddTitle.TabIndex = 8;
            this.AddTitle.Text = "Add To Function";
            this.AddTitle.UseVisualStyleBackColor = true;
            this.AddTitle.Click += new System.EventHandler(this.AddTitle_Click);
            // 
            // DepartmentList
            // 
            this.DepartmentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentList.FormattingEnabled = true;
            this.DepartmentList.ItemHeight = 13;
            this.DepartmentList.Location = new System.Drawing.Point(110, 222);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.Size = new System.Drawing.Size(225, 21);
            this.DepartmentList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Department";
            // 
            // AddDepartment
            // 
            this.AddDepartment.Location = new System.Drawing.Point(5, 220);
            this.AddDepartment.Name = "AddDepartment";
            this.AddDepartment.Size = new System.Drawing.Size(100, 25);
            this.AddDepartment.TabIndex = 8;
            this.AddDepartment.Text = "Add To Function";
            this.AddDepartment.UseVisualStyleBackColor = true;
            this.AddDepartment.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // SpecialFunctionList
            // 
            this.SpecialFunctionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecialFunctionList.FormattingEnabled = true;
            this.SpecialFunctionList.ItemHeight = 13;
            this.SpecialFunctionList.Location = new System.Drawing.Point(110, 112);
            this.SpecialFunctionList.Name = "SpecialFunctionList";
            this.SpecialFunctionList.Size = new System.Drawing.Size(225, 21);
            this.SpecialFunctionList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Special Functions";
            // 
            // AddSpecial
            // 
            this.AddSpecial.Location = new System.Drawing.Point(5, 110);
            this.AddSpecial.Name = "AddSpecial";
            this.AddSpecial.Size = new System.Drawing.Size(100, 25);
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
            this.CustomFunctionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomFunctionList.FormattingEnabled = true;
            this.CustomFunctionList.ItemHeight = 13;
            this.CustomFunctionList.Location = new System.Drawing.Point(110, 57);
            this.CustomFunctionList.Name = "CustomFunctionList";
            this.CustomFunctionList.Size = new System.Drawing.Size(225, 21);
            this.CustomFunctionList.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saved Functions";
            // 
            // AddCustom
            // 
            this.AddCustom.Location = new System.Drawing.Point(5, 55);
            this.AddCustom.Name = "AddCustom";
            this.AddCustom.Size = new System.Drawing.Size(100, 25);
            this.AddCustom.TabIndex = 8;
            this.AddCustom.Text = "Add To Function";
            this.AddCustom.UseVisualStyleBackColor = true;
            this.AddCustom.Click += new System.EventHandler(this.AddCustom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddSpecial);
            this.groupBox1.Controls.Add(this.AddDepartment);
            this.groupBox1.Controls.Add(this.AddTitle);
            this.groupBox1.Controls.Add(this.AddCustom);
            this.groupBox1.Controls.Add(this.CustomFunctionList);
            this.groupBox1.Controls.Add(this.SpecialFunctionList);
            this.groupBox1.Controls.Add(this.AddUniversity);
            this.groupBox1.Controls.Add(this.JobTitleList);
            this.groupBox1.Controls.Add(this.DepartmentList);
            this.groupBox1.Controls.Add(this.UniversityList);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(571, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 341);
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
            this.DebugTextBox.TabIndex = 1;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ProgramPEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 374);
            this.Controls.Add(this.DebugTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Button button2;
    }
}