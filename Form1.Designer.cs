namespace ProbabilityToExcel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.probAppDataSet = new ProbabilityToExcel.ProbAppDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProbabilityToExcel.ProbAppDataSetTableAdapters.EmployeeTableAdapter();
            this.iDEMPLOYEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUNIVERSITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJOBTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDEPARTMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDEMOGRAPHICDATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALSALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEMPLOYEEDataGridViewTextBoxColumn,
            this.iDUNIVERSITYDataGridViewTextBoxColumn,
            this.iDJOBTITLEDataGridViewTextBoxColumn,
            this.iDDEPARTMENTDataGridViewTextBoxColumn,
            this.iDDEMOGRAPHICDATADataGridViewTextBoxColumn,
            this.tOTALSALARYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 85);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // probAppDataSet
            // 
            this.probAppDataSet.DataSetName = "ProbAppDataSet";
            this.probAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.probAppDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // iDEMPLOYEEDataGridViewTextBoxColumn
            // 
            this.iDEMPLOYEEDataGridViewTextBoxColumn.DataPropertyName = "ID_EMPLOYEE";
            this.iDEMPLOYEEDataGridViewTextBoxColumn.HeaderText = "ID_EMPLOYEE";
            this.iDEMPLOYEEDataGridViewTextBoxColumn.Name = "iDEMPLOYEEDataGridViewTextBoxColumn";
            // 
            // iDUNIVERSITYDataGridViewTextBoxColumn
            // 
            this.iDUNIVERSITYDataGridViewTextBoxColumn.DataPropertyName = "ID_UNIVERSITY";
            this.iDUNIVERSITYDataGridViewTextBoxColumn.HeaderText = "ID_UNIVERSITY";
            this.iDUNIVERSITYDataGridViewTextBoxColumn.Name = "iDUNIVERSITYDataGridViewTextBoxColumn";
            // 
            // iDJOBTITLEDataGridViewTextBoxColumn
            // 
            this.iDJOBTITLEDataGridViewTextBoxColumn.DataPropertyName = "ID_JOB_TITLE";
            this.iDJOBTITLEDataGridViewTextBoxColumn.HeaderText = "ID_JOB_TITLE";
            this.iDJOBTITLEDataGridViewTextBoxColumn.Name = "iDJOBTITLEDataGridViewTextBoxColumn";
            // 
            // iDDEPARTMENTDataGridViewTextBoxColumn
            // 
            this.iDDEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "ID_DEPARTMENT";
            this.iDDEPARTMENTDataGridViewTextBoxColumn.HeaderText = "ID_DEPARTMENT";
            this.iDDEPARTMENTDataGridViewTextBoxColumn.Name = "iDDEPARTMENTDataGridViewTextBoxColumn";
            // 
            // iDDEMOGRAPHICDATADataGridViewTextBoxColumn
            // 
            this.iDDEMOGRAPHICDATADataGridViewTextBoxColumn.DataPropertyName = "ID_DEMOGRAPHIC_DATA";
            this.iDDEMOGRAPHICDATADataGridViewTextBoxColumn.HeaderText = "ID_DEMOGRAPHIC_DATA";
            this.iDDEMOGRAPHICDATADataGridViewTextBoxColumn.Name = "iDDEMOGRAPHICDATADataGridViewTextBoxColumn";
            // 
            // tOTALSALARYDataGridViewTextBoxColumn
            // 
            this.tOTALSALARYDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_SALARY";
            this.tOTALSALARYDataGridViewTextBoxColumn.HeaderText = "TOTAL_SALARY";
            this.tOTALSALARYDataGridViewTextBoxColumn.Name = "tOTALSALARYDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 263);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProbAppDataSet probAppDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ProbAppDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLOYEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUNIVERSITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJOBTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEPARTMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEMOGRAPHICDATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALSALARYDataGridViewTextBoxColumn;
    }
}

