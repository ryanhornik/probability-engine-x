using ProbToExcelRebuild.Models;
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
    public partial class ManualEntryEmployee : Form
    {
        private UniversityModel db = new UniversityModel();

        public ManualEntryEmployee()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            JobTitleComboBox.SelectedIndex = -1;
            DepartmentComboBox.SelectedItem = -1;
            UniversityComboBox.SelectedItem = -1;
            SalaryTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string jobtitle;
            string department;
            string university;
            decimal salary;

            try
            {
                jobtitle = JobTitleComboBox.Text.ToString();
                department = DepartmentComboBox.Text.ToString();
                university = UniversityComboBox.Text.ToString();
                salary = decimal.Parse(SalaryTextBox.Text);
            }
            catch(Exception)
            {
                jobtitle = JobTitleComboBox.SelectedText.ToString();
                department = DepartmentComboBox.SelectedText.ToString();
                university = UniversityComboBox.SelectedText.ToString();
                salary = decimal.Parse(SalaryTextBox.Text);
            }

            Job_Title job_title;
            if(db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(jobtitle)))
            {
                job_title = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobtitle));
            }
            else
            {
                job_title = new Job_Title()
                {
                    JOB_TITLE_NAME = jobtitle
                };
                db.Job_Title.Add(job_title);
                db.SaveChanges();
            }
            Department dprtmt;
            if(db.Departments.Any(s => s.ID_DEPARTMENT.Equals(department)))
            {
                dprtmt = db.Departments.First(s => s.ID_DEPARTMENT.Equals(department));
            }
            else
            {
                dprtmt = new Department()
                {
                    ID_DEPARTMENT = department
                };
                db.Departments.Add(dprtmt);
                db.SaveChanges();
            }

            University uni;
            if(db.Universities.Any(s => s.UNIVERSITY_NAME.Equals(university)))
            {
                uni = db.Universities.First(s => s.UNIVERSITY_NAME.Equals(university));
            }
            else
            {
                uni = new University()
                {
                    UNIVERSITY_NAME = university
                };
                db.Universities.Add(uni);
                db.SaveChanges();
            }

            Employee sal = new Employee()
            {
                TOTAL_SALARY = salary,
                ID_UNIVERSITY = db.Universities.First(s => s.UNIVERSITY_NAME.Equals(uni.UNIVERSITY_NAME)).ID_UNIVERSITY,
                ID_JOB_TITLE = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(job_title.JOB_TITLE_NAME)).ID_JOB_TITLE,
                ID_DEPARTMENT = db.Departments.First(s => s.ID_DEPARTMENT.Equals(dprtmt.ID_DEPARTMENT)).ID_DEPARTMENT
            };

            db.Employees.Add(sal);
            db.SaveChanges();
    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void ManualEntryEmployee_Load(object sender, EventArgs e)
        {
            UniversityComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            UniversityComboBox.Items.AddRange(db.Universities.ToArray());
            JobTitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            JobTitleComboBox.Items.AddRange(db.Job_Title.ToArray());
            DepartmentComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            DepartmentComboBox.Items.AddRange(db.Departments.ToArray());
        }

        private void JobTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
