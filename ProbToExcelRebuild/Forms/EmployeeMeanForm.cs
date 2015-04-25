using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            var groupBy = MeanComboBox.SelectedItem.ToString();
            List<Averageable> prop;
            switch (groupBy)
            {
                case "University":
                    prop = new List<Averageable>(db.Universities);
                    break;
                case "Job Title":
                    prop = new List<Averageable>(db.Job_Title);
                    break;
                case "Department":
                    prop = new List<Averageable>(db.Departments);
                    break;
                default:
                    prop = new List<Averageable>();
                    break;
            }

            MeanAssGrid.Columns[0].HeaderText = groupBy;

            var rowCount = MeanAssGrid.Rows.Count;
            for (var i = rowCount - 1; i >= 0; i--)
            {
                MeanAssGrid.Rows.RemoveAt(i);
            }

            foreach (var avg in prop)
            {
                var averages = avg.CalculateAverages();
                var row = new object[5];
                row[0] = avg.ToString();
                row[1] = averages.mean;
                row[2] = averages.IQR1;
                row[3] = averages.median;
                row[4] = averages.IQR3;
                MeanAssGrid.Rows.Add(row);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainWindow x = new MainWindow();
            Hide();
            x.Show();
            Close();

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

        private void MeanAssGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
