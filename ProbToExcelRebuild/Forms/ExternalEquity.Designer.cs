namespace ProbToExcelRebuild.Forms
{
    partial class ExternalEquity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalEquity));
            this.equityGrid = new System.Windows.Forms.DataGridView();
            this.Job_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average_UH_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average_Tier_1_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.External_Equity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // equityGrid
            // 
            this.equityGrid.AllowUserToAddRows = false;
            this.equityGrid.AllowUserToDeleteRows = false;
            this.equityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job_Title,
            this.Average_UH_Salary,
            this.Average_Tier_1_Salary,
            this.External_Equity});
            this.equityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equityGrid.Location = new System.Drawing.Point(0, 0);
            this.equityGrid.Name = "equityGrid";
            this.equityGrid.ReadOnly = true;
            this.equityGrid.Size = new System.Drawing.Size(700, 262);
            this.equityGrid.TabIndex = 0;
            // 
            // Job_Title
            // 
            this.Job_Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Job_Title.HeaderText = "Job Title";
            this.Job_Title.Name = "Job_Title";
            this.Job_Title.ReadOnly = true;
            // 
            // Average_UH_Salary
            // 
            this.Average_UH_Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Average_UH_Salary.HeaderText = "Average UH Salary";
            this.Average_UH_Salary.Name = "Average_UH_Salary";
            this.Average_UH_Salary.ReadOnly = true;
            // 
            // Average_Tier_1_Salary
            // 
            this.Average_Tier_1_Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Average_Tier_1_Salary.HeaderText = "Average Tier 1 Salary";
            this.Average_Tier_1_Salary.Name = "Average_Tier_1_Salary";
            this.Average_Tier_1_Salary.ReadOnly = true;
            // 
            // External_Equity
            // 
            this.External_Equity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.External_Equity.HeaderText = "External Equity";
            this.External_Equity.Name = "External_Equity";
            this.External_Equity.ReadOnly = true;
            // 
            // ExternalEquity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 262);
            this.Controls.Add(this.equityGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExternalEquity";
            this.Text = "External Equity";
            this.Load += new System.EventHandler(this.ExternalEquity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView equityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average_UH_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average_Tier_1_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn External_Equity;
    }
}