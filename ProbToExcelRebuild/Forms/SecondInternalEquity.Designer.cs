﻿namespace ProbToExcelRebuild.Forms
{
    partial class SecondInternalEquity
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
            this.secondInternalEquityGrid = new System.Windows.Forms.DataGridView();
            this.JOB_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tier_One_Weighted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UH_Weighted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second_Int_Eq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.secondInternalEquityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // secondInternalEquityGrid
            // 
            this.secondInternalEquityGrid.AllowUserToAddRows = false;
            this.secondInternalEquityGrid.AllowUserToDeleteRows = false;
            this.secondInternalEquityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondInternalEquityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JOB_TITLE,
            this.Tier_One_Weighted,
            this.UH_Weighted,
            this.Second_Int_Eq});
            this.secondInternalEquityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondInternalEquityGrid.Location = new System.Drawing.Point(0, 0);
            this.secondInternalEquityGrid.Name = "secondInternalEquityGrid";
            this.secondInternalEquityGrid.ReadOnly = true;
            this.secondInternalEquityGrid.Size = new System.Drawing.Size(651, 261);
            this.secondInternalEquityGrid.TabIndex = 0;
            // 
            // JOB_TITLE
            // 
            this.JOB_TITLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JOB_TITLE.HeaderText = "Job Title";
            this.JOB_TITLE.Name = "JOB_TITLE";
            this.JOB_TITLE.ReadOnly = true;
            // 
            // Tier_One_Weighted
            // 
            this.Tier_One_Weighted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tier_One_Weighted.HeaderText = "Tier 1 Weighted Salary";
            this.Tier_One_Weighted.Name = "Tier_One_Weighted";
            this.Tier_One_Weighted.ReadOnly = true;
            // 
            // UH_Weighted
            // 
            this.UH_Weighted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UH_Weighted.HeaderText = "UH Weighted Salary";
            this.UH_Weighted.Name = "UH_Weighted";
            this.UH_Weighted.ReadOnly = true;
            // 
            // Second_Int_Eq
            // 
            this.Second_Int_Eq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Second_Int_Eq.HeaderText = "Second Internal Equity";
            this.Second_Int_Eq.Name = "Second_Int_Eq";
            this.Second_Int_Eq.ReadOnly = true;
            // 
            // SecondInternalEquity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.secondInternalEquityGrid);
            this.Name = "SecondInternalEquity";
            this.Text = "SecondInternalEquity";
            this.Load += new System.EventHandler(this.SecondInternalEquity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondInternalEquityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView secondInternalEquityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tier_One_Weighted;
        private System.Windows.Forms.DataGridViewTextBoxColumn UH_Weighted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second_Int_Eq;
    }
}