namespace ProbToExcelRebuild.Forms
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageNewHireSalariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averagesPerSalaryPerDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUHDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterTier1DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ID_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIVERSITY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOB_TITLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newHireAveragesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_HIRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newHireAveragesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.manualInputToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.averageNewHireSalariesToolStripMenuItem,
            this.averagesPerSalaryPerDepartmentToolStripMenuItem});
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importDataToolStripMenuItem.Text = "Import Excel Data";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.excelToolStripMenuItem.Text = "Employees";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // averageNewHireSalariesToolStripMenuItem
            // 
            this.averageNewHireSalariesToolStripMenuItem.Name = "averageNewHireSalariesToolStripMenuItem";
            this.averageNewHireSalariesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.averageNewHireSalariesToolStripMenuItem.Text = "Average New Hire Salaries";
            this.averageNewHireSalariesToolStripMenuItem.Click += new System.EventHandler(this.averageNewHireSalariesToolStripMenuItem_Click);
            // 
            // averagesPerSalaryPerDepartmentToolStripMenuItem
            // 
            this.averagesPerSalaryPerDepartmentToolStripMenuItem.Name = "averagesPerSalaryPerDepartmentToolStripMenuItem";
            this.averagesPerSalaryPerDepartmentToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.averagesPerSalaryPerDepartmentToolStripMenuItem.Text = "Averages Per Salary Per Department";
            this.averagesPerSalaryPerDepartmentToolStripMenuItem.Click += new System.EventHandler(this.averagesPerSalaryPerDepartmentToolStripMenuItem_Click);
            // 
            // manualInputToolStripMenuItem
            // 
            this.manualInputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterUHDataToolStripMenuItem,
            this.enterTier1DataToolStripMenuItem});
            this.manualInputToolStripMenuItem.Name = "manualInputToolStripMenuItem";
            this.manualInputToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.manualInputToolStripMenuItem.Text = "Manual Input";
            // 
            // enterUHDataToolStripMenuItem
            // 
            this.enterUHDataToolStripMenuItem.Name = "enterUHDataToolStripMenuItem";
            this.enterUHDataToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.enterUHDataToolStripMenuItem.Text = "UH Data";
            this.enterUHDataToolStripMenuItem.Click += new System.EventHandler(this.enterUHDataToolStripMenuItem_Click);
            // 
            // enterTier1DataToolStripMenuItem
            // 
            this.enterTier1DataToolStripMenuItem.Name = "enterTier1DataToolStripMenuItem";
            this.enterTier1DataToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.enterTier1DataToolStripMenuItem.Text = "Other Tier 1 Data";
            this.enterTier1DataToolStripMenuItem.Click += new System.EventHandler(this.enterTier1DataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // employeeGrid
            // 
            this.employeeGrid.AllowUserToAddRows = false;
            this.employeeGrid.AllowUserToDeleteRows = false;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Employee,
            this.TOTAL_SALARY,
            this.UNIVERSITY_NAME,
            this.ID_DEPARTMENT,
            this.JOB_TITLE_NAME});
            this.employeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGrid.Location = new System.Drawing.Point(3, 3);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.ReadOnly = true;
            this.employeeGrid.Size = new System.Drawing.Size(565, 291);
            this.employeeGrid.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 323);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.employeeGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newHireAveragesGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Hire Averages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ID_Employee
            // 
            this.ID_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Employee.HeaderText = "Employee ID";
            this.ID_Employee.Name = "ID_Employee";
            this.ID_Employee.ReadOnly = true;
            // 
            // TOTAL_SALARY
            // 
            this.TOTAL_SALARY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL_SALARY.HeaderText = "Total Salary";
            this.TOTAL_SALARY.Name = "TOTAL_SALARY";
            this.TOTAL_SALARY.ReadOnly = true;
            // 
            // UNIVERSITY_NAME
            // 
            this.UNIVERSITY_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UNIVERSITY_NAME.HeaderText = "University Name";
            this.UNIVERSITY_NAME.Name = "UNIVERSITY_NAME";
            this.UNIVERSITY_NAME.ReadOnly = true;
            // 
            // ID_DEPARTMENT
            // 
            this.ID_DEPARTMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_DEPARTMENT.HeaderText = "Department ID";
            this.ID_DEPARTMENT.Name = "ID_DEPARTMENT";
            this.ID_DEPARTMENT.ReadOnly = true;
            // 
            // JOB_TITLE_NAME
            // 
            this.JOB_TITLE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JOB_TITLE_NAME.HeaderText = "Job Title";
            this.JOB_TITLE_NAME.Name = "JOB_TITLE_NAME";
            this.JOB_TITLE_NAME.ReadOnly = true;
            // 
            // newHireAveragesGrid
            // 
            this.newHireAveragesGrid.AllowUserToAddRows = false;
            this.newHireAveragesGrid.AllowUserToDeleteRows = false;
            this.newHireAveragesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newHireAveragesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.YEAR_HIRED});
            this.newHireAveragesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newHireAveragesGrid.Location = new System.Drawing.Point(3, 3);
            this.newHireAveragesGrid.Name = "newHireAveragesGrid";
            this.newHireAveragesGrid.ReadOnly = true;
            this.newHireAveragesGrid.Size = new System.Drawing.Size(565, 291);
            this.newHireAveragesGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Average Salary";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Department ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // YEAR_HIRED
            // 
            this.YEAR_HIRED.HeaderText = "Year Hired";
            this.YEAR_HIRED.Name = "YEAR_HIRED";
            this.YEAR_HIRED.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(579, 347);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newHireAveragesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterUHDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterTier1DataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageNewHireSalariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averagesPerSalaryPerDepartmentToolStripMenuItem;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_SALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIVERSITY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_TITLE_NAME;
        private System.Windows.Forms.DataGridView newHireAveragesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_HIRED;
    }
}