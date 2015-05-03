using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbToExcelRebuild.Forms
{
    public partial class SelectColumnsEmployee : Form
    {
        public string jobTitleColumn;
        public string proposedTotalSalaryColumn;
        public string deptIDColumn;
        public string uniColumn;
        public int dataStartRow;
        private bool uniFromFile;

        public SelectColumnsEmployee(bool uniFromFile)
        {
            InitializeComponent();
            this.uniFromFile = uniFromFile;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (uniFromFile)
            {
                uniColumn = uniTextBox.Text;
            }

            jobTitleColumn = jobTitleTextBox.Text;
            proposedTotalSalaryColumn = salaryTextBox.Text;
            deptIDColumn = departmentTextBox.Text;
            dataStartRow = Convert.ToInt32(dataRowTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectColumns_Load(object sender, EventArgs e)
        {
            if (uniFromFile)
            {
                uniTextBox.Text = "C";
                jobTitleTextBox.Text = "E";
                salaryTextBox.Text = "B";
                departmentTextBox.Text = "D";
                dataRowTextBox.Text = "2";
            }
            else
            {
                unilabel.Hide();
                uniTextBox.Hide();
                jobTitleTextBox.Text = "B";
                salaryTextBox.Text = "O";
                departmentTextBox.Text = "AA";
                dataRowTextBox.Text = "8";
            }

        }
    }
}
