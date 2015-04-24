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
    public partial class SelectColumnsAverageNewHireSalaries : Form
    {
        public string averageSalaryColumn { get; set; }
        public string yearHiredColumn { get; set; }
        public string deptIDColumn { get; set; }
        public int dataStartRow { get; set; }

        public SelectColumnsAverageNewHireSalaries()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            averageSalaryColumn = averageSalaryTextBox.Text;
            yearHiredColumn = yearHiredTextBox.Text;
            deptIDColumn = departmentIDTextBox.Text;
            dataStartRow = Convert.ToInt32(dataStartTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectColumnsAverageNewHireSalaries_Load(object sender, EventArgs e)
        {
            averageSalaryTextBox.Text = "A";
            yearHiredTextBox.Text = "B";
            departmentIDTextBox.Text = "C";
            dataStartTextBox.Text = "2";
        }
    }
}
