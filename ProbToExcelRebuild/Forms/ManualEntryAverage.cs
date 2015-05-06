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
    public partial class ManualEntryAverage : Form
    {
        private UniversityModel db = new UniversityModel();
        public ManualEntryAverage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            string department;
            decimal salary;


            try
            {
                year = int.Parse(YearTextBox.Text.ToString());
                department = DeptmtComboBox.Text.ToString();
                salary = decimal.Parse(SalaryTextBox.Text.ToString());
            }
            catch (Exception)
            {
                year = int.Parse(YearTextBox.SelectedText.ToString());
                department = DeptmtComboBox.SelectedText.ToString();
                salary = decimal.Parse(SalaryTextBox.SelectedText.ToString());
            }

            Department dpt;
            if (db.Departments.Any(s => s.ID_DEPARTMENT.Equals(department)))
            {
                dpt = db.Departments.First(s => s.ID_DEPARTMENT.Equals(department));
            }
            else
            {
                dpt = new Department()
                {
                    ID_DEPARTMENT = department
                };
                db.Departments.Add(dpt);
                db.SaveChanges();
            }

            New_Associate_Professor_Average_Salary x = new New_Associate_Professor_Average_Salary()
            {
                YEAR = year,
                AVERAGE_SALARY = salary,
                ID_DEPARTMENT = dpt.ID_DEPARTMENT
            };

            db.New_Associate_Professor_Average_Salary.Add(x);
            db.SaveChanges();
            Invoke(new Action(UpdateGridView));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateGridView()
        {
            try
            {
                foreach(var avgEmp in db.New_Associate_Professor_Average_Salary)
                {
                    var row = new object[3];
                    row[0] = avgEmp.YEAR;
                    row[1] = avgEmp.AVERAGE_SALARY.ToString("$000,000.00");
                    row[2] = avgEmp.ID_DEPARTMENT;
                    GridView.Rows.Add(row);
                    
                }
                MessageBox.Show("Added Successfully!");
            }
            catch(Exception ex)
            {
                new ErrorMessageBox(ex, "Gridview failed to update").ShowDialog();
            }
        }

        private void DeptmtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManualEntryAverage_Load(object sender, EventArgs e)
        {
            DeptmtComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            DeptmtComboBox.Items.AddRange(db.Departments.ToArray());
        }
    }
}
