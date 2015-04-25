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
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherTier1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quartilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.calculateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
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
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.otherTier1ToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.quartilesToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeeToolStripMenuItem.Text = "UH Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // otherTier1ToolStripMenuItem
            // 
            this.otherTier1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanToolStripMenuItem1,
            this.medianToolStripMenuItem1,
            this.quartilesToolStripMenuItem1});
            this.otherTier1ToolStripMenuItem.Name = "otherTier1ToolStripMenuItem";
            this.otherTier1ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.otherTier1ToolStripMenuItem.Text = "Other Tier 1";
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medianToolStripMenuItem.Text = "Median";
            // 
            // quartilesToolStripMenuItem
            // 
            this.quartilesToolStripMenuItem.Name = "quartilesToolStripMenuItem";
            this.quartilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quartilesToolStripMenuItem.Text = "Quartiles";
            // 
            // meanToolStripMenuItem1
            // 
            this.meanToolStripMenuItem1.Name = "meanToolStripMenuItem1";
            this.meanToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.meanToolStripMenuItem1.Text = "Mean";
            // 
            // medianToolStripMenuItem1
            // 
            this.medianToolStripMenuItem1.Name = "medianToolStripMenuItem1";
            this.medianToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.medianToolStripMenuItem1.Text = "Median";
            // 
            // quartilesToolStripMenuItem1
            // 
            this.quartilesToolStripMenuItem1.Name = "quartilesToolStripMenuItem1";
            this.quartilesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quartilesToolStripMenuItem1.Text = "Quartiles";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 287);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherTier1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartilesToolStripMenuItem1;
    }
}