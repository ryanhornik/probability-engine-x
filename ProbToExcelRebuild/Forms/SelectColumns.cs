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
    public partial class SelectColumns : Form
    {
        public string jobTitleColumn;
        public string proposedTotalSalaryColumn;
        public string deptIDColumn;
        public int dataStartRow;

        public SelectColumns()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
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
            jobTitleTextBox.Text = "B";
            salaryTextBox.Text = "O";
            departmentTextBox.Text = "AA";
            dataRowTextBox.Text = "8";
        }
    }
}
