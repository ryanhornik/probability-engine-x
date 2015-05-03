namespace ProbToExcelRebuild.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondInternalEquity));
            this.secondInternalEquityGrid = new System.Windows.Forms.DataGridView();
            this.JOB_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tier_One_Weighted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UH_Weighted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second_Int_Eq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
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
            this.secondInternalEquityGrid.Dock = System.Windows.Forms.DockStyle.Top;
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
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(383, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 30);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(173, 267);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(99, 30);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export To Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // SecondInternalEquity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 307);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.secondInternalEquityGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecondInternalEquity";
            this.Text = "Second Internal Equity";
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exportButton;
    }
}