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
        public string Document1SpecialtyCodeColumn { get; set; }
        public string Document1CodeWeightColumn { get; set; }
        public string Document1DepartmentIdColumn { get; set; }
        public int Document1DataRow { get; set; }

        public string Document2SpecialtyCodeColumn { get; set; }
        public string Document2SalaryColumn { get; set; }
        public string Document2JobTitleColumn { get; set; }
        public int Document2DataRow { get; set; }


        public SelectColumnsPerDepartmentPerSpecialCode()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Document1SpecialtyCodeColumn = specialtyCode1TextBox.Text;
            Document1CodeWeightColumn = weightTextBox.Text;
            Document1DepartmentIdColumn = deptIDTextBox.Text;
            Document1DataRow = Convert.ToInt32(dataRow1TextBox.Text);
            
            Document2SpecialtyCodeColumn = specialtyCode2TextBox.Text;
            Document2SalaryColumn = averageSalaryTextBox.Text;
            Document2JobTitleColumn = jobTitleTextBox.Text;
            Document2DataRow = Convert.ToInt32(dataRow2TextBox.Text);

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
            specialtyCode1TextBox.Text = "A";
            weightTextBox.Text = "D";
            deptIDTextBox.Text = "C";
            dataRow1TextBox.Text = "2";

            specialtyCode2TextBox.Text = "C";
            averageSalaryTextBox.Text = "A";
            jobTitleTextBox.Text = "B";
            dataRow2TextBox.Text = "2";
        }
    }
}
