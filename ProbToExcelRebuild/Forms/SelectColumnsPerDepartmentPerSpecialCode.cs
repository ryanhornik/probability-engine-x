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
    public partial class SelectColumnsPerDepartmentPerSpecialCode : Form
    {
        public string averageSalaryColumn { get; set; }
        public string specialtyCodeColumn { get; set; }
        public string jobTitleColumn { get; set; }
        public string weightColumn { get; set; }
        public string deptIDColumn { get; set; }
        public int dataStartRow { get; set; }

        public SelectColumnsPerDepartmentPerSpecialCode()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            averageSalaryColumn = averageSalaryTextBox.Text;
            specialtyCodeColumn = specialtyCodeTextBox.Text;
            jobTitleColumn = jobTitleTextBox.Text;
            weightColumn = weightTextBox.Text;
            deptIDColumn = deptIDTextBox.Text;
            dataStartRow = Convert.ToInt32(dataRowTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectColumnsPerDepartmentPerSpecialCode_Load(object sender, EventArgs e)
        {
            averageSalaryTextBox.Text = "E";
            specialtyCodeTextBox.Text = "A";
            jobTitleTextBox.Text = "D";
            weightTextBox.Text = "C";
            deptIDTextBox.Text = "B";
            dataRowTextBox.Text = "2";
        }
    }
}
