using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbToExcelRebuild.Models;

namespace ProbToExcelRebuild.Forms
{
    public partial class EmployeeMeanForm : Form
    {

        private UniversityModel db = new UniversityModel();
        public EmployeeMeanForm()
        {
            InitializeComponent();
        }

        private void EmployeeMeanForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(MeanComboBox.SelectedItem.Equals("Department"))
            {
                MessageBox.Show("Department Success");
                UpdateGridByDepartment();
            }
            else if(MeanComboBox.SelectedItem.Equals("Job Title"))
            {
                MessageBox.Show("Job Title Success");
                UpdateGridByJobTitle();
            }
            else if(MeanComboBox.SelectedItem.Equals("University"))
            {
                MessageBox.Show("University Success");
                UpdateGridByUniversity();
            }
            else
                MessageBox.Show("Failure");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainWindow x = new MainWindow();
            this.Hide();
            x.Show();
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateGridByDepartment()
        {
            var rowCount = MeanAssGrid.Rows.Count;
            for (var i = rowCount - 1; i >= 0; i--)
            {
                MeanAssGrid.Rows.RemoveAt(i);
            }
            Dictionary<Department, Averages> dickbutt = new Dictionary<Department, Averages>();
            foreach (var dep in db.Departments)
            {
                var sal = dep.Employees.Sum(imp => imp.TOTAL_SALARY);
            }
        }

        private class Averages
        {
            private double mean { get; set; }
            private double median { get; set; }
            private double IQR1 { get; set; }
            private double IQR3 { get; set; }

            private Averages()
            {
                mean = 0;
                median = 0;
                IQR1 = 0;
                IQR3 = 0;
            }


        }

        private void MeanAssGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
