using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.CompilerServices;
using ProbabilityToExcel.Models;

namespace ProbabilityToExcel
{
    public partial class MainWindow : Form
    {
        Entities db = new Entities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (.xls, .xlsx)|*.xlsx;*.xls",
                FilterIndex = 1,
                Multiselect = false
            };

            University university = null;

            using (var form = new SelectUniversity())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    university = form.SelectedUniversity;
                }
            }

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK && university != null)
            {
                LoadExcelData(openFileDialog.FileName, university);
            }
        }

        private void LoadExcelData(String filePath, University university)
        {
            var application = new Excel.Application();
            var workbook = application.Workbooks.Open(filePath);
            var worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
            object misValue = Missing.Value;

            var jobTitleColumn = "B";
            var proposedTotalSalaryColumn = "O";
            var deptIDColumn = "AA";
            var dataStartRow = 8;

            while (worksheet.Range[deptIDColumn + dataStartRow].Value2 != null)
            {

                var jobTitle = worksheet.Range[(jobTitleColumn + dataStartRow)].Value2;

                var proposedTotalSalary = worksheet.Range[proposedTotalSalaryColumn + dataStartRow].Value2;

                var deptID = worksheet.Range[deptIDColumn + dataStartRow].Value2;

                if (jobTitle != null)
                {
                    Department dept;
                    string deptIDString = deptID.ToString();
                    if (db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                    {
                        dept = db.Departments.Find(deptID.ToString());
                    }
                    else
                    {
                        dept = new Department()
                        {
                            ID_DEPARTMENT = deptID.ToString()
                        };
                        db.Departments.Add(dept);
                        db.SaveChanges();
                    }

                    Job_Title title;
                    string jobTitleString = jobTitle.ToString();
                    if (db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)))
                    {
                        title = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobTitleString));
                    }
                    else
                    {
                        title = new Job_Title()
                        {
                            JOB_TITLE_NAME = jobTitle.ToString()
                        };
                        db.Job_Title.Add(title);
                        db.SaveChanges();
                    }

                    db.Employees.Add(
                        new Employee()
                    {
                        Department = dept,
                        Job_Title = title,
                        University = university,
                        TOTAL_SALARY = (decimal)proposedTotalSalary,
                        Demographic_Data = null
                    });
                    db.SaveChanges();
                }

                dataStartRow++;

            }

            workbook.Close(true, misValue, misValue);
            application.Quit();

            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(application);
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        //Not used?

        private void enterUHDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualEntry manualForm = new ManualEntry();
            this.Hide();
            manualForm.Show();
        }

        private void enterTier1DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tier1ManualEntry manualForm = new Tier1ManualEntry();
            this.Hide();
            manualForm.Show();
        }
    }
}
