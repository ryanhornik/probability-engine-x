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
    public partial class SpecialCodeManualEntry : Form
    {
        UniversityModel db = new UniversityModel();

        public SpecialCodeManualEntry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void JobTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string scode = SpecialtyCodeTextBox.Text;
            string jobtitle = JobTitleComboBox.Text;
            string department = comboBox1.Text;
            double weight = double.Parse(textBox1.Text);
            decimal avgSal = decimal.Parse(AvgTierSalTextBox.Text);
            string university = UniversityComboBox.Text;

            Department d;
            if (db.Departments.Any(s => s.ID_DEPARTMENT.Equals(department)))
            {
                d = db.Departments.First(s => s.ID_DEPARTMENT.Equals(department));
            }
            else
            {
                d = new Department()
                {
                    ID_DEPARTMENT = department
                };
                db.Departments.Add(d);
                db.SaveChanges();
            }


            Specialty_Code id;
            if (db.Specialty_Code.Any(s => s.ID_CODE.Equals(scode)))
            {
                id = db.Specialty_Code.First(s => s.ID_CODE.Equals(scode));
            }
            else
            {
                id = new Specialty_Code()
                {
                    ID_CODE = scode,
                    WEIGHT = weight,
                    ID_DEPARTMENT = department
                };
                db.Specialty_Code.Add(id);
                db.SaveChanges();
            }


            Job_Title k;
            if (db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(jobtitle)))
            {
                k = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobtitle));
            }
            else
            {
                k = new Job_Title()
                {
                    JOB_TITLE_NAME = jobtitle
                };
                db.Job_Title.Add(k);
                db.SaveChanges();
            }

            Per_Job_Per_Department f = new Per_Job_Per_Department()
            {
                AVERAGE_SALARY = avgSal,
                ID_UNIVERSITY = db.Universities.First(s => s.UNIVERSITY_NAME.Equals(university)).ID_UNIVERSITY,
                ID_CODE = scode,
                ID_JOB_TITLE = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobtitle)).ID_JOB_TITLE
            };

            db.Per_Job_Per_Department.Add(f);
            db.SaveChanges();







        }

        private void UpdateIdByIdGridView()
        {
            var rowCount = SpecialtyGridView.Rows.Count;
            for (var i = rowCount - 1; i >= 0; i--)
            {
                SpecialtyGridView.Rows.RemoveAt(i);
            }
            foreach (var s in db.Specialty_Code)
            {
                var row = new object[0];
                row[0] = s.ID_CODE;
                SpecialtyGridView.Rows.Add(row);
            }
        }

        private void SpecialtyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SpecialCodeManualEntry_Load(object sender, EventArgs e)
        {
            UniversityComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            UniversityComboBox.Items.AddRange(db.Universities.ToArray());
        }

        private void SelectUniversities_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UniversityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
