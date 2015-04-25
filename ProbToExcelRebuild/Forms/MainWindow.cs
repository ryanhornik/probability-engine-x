using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ProbToExcelRebuild.Models;

namespace ProbToExcelRebuild.Forms
{
    public partial class MainWindow : Form
    {
        private UniversityModel db = new UniversityModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University university;

            using (var form = new SelectUniversity())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    university = form.SelectedUniversity;
                }
                else
                {
                    return;
                }
            }

            string jobTitleColumn;
            string proposedTotalSalaryColumn;
            string deptIDColumn;
            int dataStartRow;

            using (var form = new SelectColumnsEmployee())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    jobTitleColumn = form.jobTitleColumn;
                    proposedTotalSalaryColumn = form.proposedTotalSalaryColumn;
                    deptIDColumn = form.deptIDColumn;
                    dataStartRow = form.dataStartRow;
                }
                else
                {
                    return;
                }
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (.xls, .xlsx)|*.xlsx;*.xls",
                FilterIndex = 1,
                Multiselect = false
            };

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK && university != null)
            {
                var loadForm = new LoadingSplash();
                loadForm.Show();
                Hide();

                var thread = new Thread(() =>
                {
                    var application = new Excel.Application();
                    var workbook = application.Workbooks.Open(openFileDialog.FileName);
                    var worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
                    object misValue = Missing.Value;

                    var dataCurrentRow = dataStartRow;

                    try
                    {
                        var newDepartments = new List<Department>();
                        var newJobTitles = new List<Job_Title>();
                        var newEmployees = new List<Employee>();

                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("First pass of two - " + (dataCurrentRow - dataStartRow) + "/? rows processed"))));

                            var jobTitle = worksheet.Range[(jobTitleColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            if (jobTitle != null)
                            {
                                string deptIDString = deptID.ToString();
                                if (!db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)) && !newDepartments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                                {
                                    newDepartments.Add(new Department()
                                    {
                                        ID_DEPARTMENT = deptID.ToString()
                                    });
                                }

                                string jobTitleString = jobTitle.ToString();
                                if (!db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)) && !newJobTitles.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)))
                                {
                                    newJobTitles.Add(new Job_Title()
                                    {
                                        JOB_TITLE_NAME = jobTitle.ToString()
                                    });
                                }
                            }

                            dataCurrentRow++;
                        }

                        var totalRows = dataCurrentRow - dataStartRow;
                        db.Departments.AddRange(newDepartments);
                        db.SaveChanges();

                        db.Job_Title.AddRange(newJobTitles);
                        db.SaveChanges();

                        dataCurrentRow = dataStartRow;
                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {

                            var jobTitle = worksheet.Range[(jobTitleColumn + dataCurrentRow)].Value2;

                            var proposedTotalSalary = worksheet.Range[proposedTotalSalaryColumn + dataCurrentRow].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            if (jobTitle != null)
                            {
                                string deptIDString = deptID.ToString();
                                Department dept = db.Departments.First(s => s.ID_DEPARTMENT == deptIDString);

                                string jobTitleString = jobTitle.ToString();
                                Job_Title title = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobTitleString));


                                newEmployees.Add(
                                    new Employee()
                                    {
                                        ID_DEPARTMENT = dept.ID_DEPARTMENT,
                                        ID_JOB_TITLE = title.ID_JOB_TITLE,
                                        ID_UNIVERSITY = university.ID_UNIVERSITY,
                                        TOTAL_SALARY = (decimal)proposedTotalSalary
                                    });
                            }
                            dataCurrentRow++;
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("Second pass of two - " + (dataCurrentRow - dataStartRow) + "/" + totalRows + " rows processed"))));
                        }

                        loadForm.Invoke((new Action(() => loadForm.updateLabel("Saving changes to database"))));
                        db.Employees.AddRange(newEmployees);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Import Failed: " + ex.Message);
                    }

                    workbook.Close(true, misValue, misValue);
                    application.Quit();

                    ReleaseObject(worksheet);
                    ReleaseObject(workbook);
                    ReleaseObject(application);

                    loadForm.Invoke(new Action(() => { loadForm.Close(); }));
                    Invoke(new Action(Show));
                });
                thread.Start();
            }
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

        private void enterUHDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO add manual entry form for UH data
        }

        private void enterTier1DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO add manual entry form for other tier 1s
        }

        private void averageNewHireSalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string averageSalaryColumn;
            string yearHiredColumn;
            string deptIDColumn;
            int dataStartRow;

            using (var form = new SelectColumnsAverageNewHireSalaries())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    averageSalaryColumn = form.averageSalaryColumn;
                    yearHiredColumn = form.yearHiredColumn;
                    deptIDColumn = form.deptIDColumn;
                    dataStartRow = form.dataStartRow;
                }
                else
                {
                    return;
                }
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (.xls, .xlsx)|*.xlsx;*.xls",
                FilterIndex = 1,
                Multiselect = false
            };

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var loadForm = new LoadingSplash();
                loadForm.Show();
                Hide();

                var thread = new Thread(() =>
                {
                    var application = new Excel.Application();
                    var workbook = application.Workbooks.Open(openFileDialog.FileName);
                    var worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
                    object misValue = Missing.Value;

                    var dataCurrentRow = dataStartRow;

                    try
                    {
                        var newDepartments = new List<Department>();

                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("First pass of two - " + (dataCurrentRow - dataStartRow) + "/? rows processed"))));

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            string deptIDString = deptID.ToString();
                            if (!db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)) && !newDepartments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                            {
                                newDepartments.Add(new Department()
                                {
                                    ID_DEPARTMENT = deptID.ToString()
                                });
                            }

                            dataCurrentRow++;
                        }
                        
                        loadForm.Invoke((new Action(() => loadForm.updateLabel("Saving changes to database"))));

                        db.Departments.AddRange(newDepartments);
                        db.SaveChanges();

                        var totalRows = dataCurrentRow - dataStartRow;
                        dataCurrentRow = dataStartRow;
                        var newAverageSalaries = new List<New_Associate_Professor_Average_Salary>();
                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            var averageSalary = worksheet.Range[(averageSalaryColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            var yearHired = worksheet.Range[yearHiredColumn + dataCurrentRow].Value2;

                            string deptIDString = deptID.ToString();
                            var dept = db.Departments.First(s => s.ID_DEPARTMENT.Equals(deptIDString));

                            newAverageSalaries.Add(new New_Associate_Professor_Average_Salary()
                            {
                                AVERAGE_SALARY = (decimal) averageSalary,
                                ID_DEPARTMENT = dept.ID_DEPARTMENT,
                                YEAR = (int) yearHired
                            }
                                );
                            dataCurrentRow++;
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("Second pass of two - " + (dataCurrentRow - dataStartRow) + "/" + totalRows + " rows processed"))));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Import Failed: " + ex.Message);
                    }

                    workbook.Close(true, misValue, misValue);
                    application.Quit();

                    ReleaseObject(worksheet);
                    ReleaseObject(workbook);
                    ReleaseObject(application);

                    loadForm.Invoke(new Action(() => { loadForm.Close(); }));
                    Invoke(new Action(Show));
                });
                thread.Start();
            }
        }

        private void averagesPerSalaryPerDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string averageSalaryColumn;
            string specialtyCodeColumn;
            string jobTitleColumn;
            string weightColumn;
            string deptIDColumn;
            int dataStartRow;

            using (var form = new SelectColumnsAverageNewHireSalaries())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    averageSalaryColumn = form.averageSalaryColumn;
                    specialtyCodeColumn = form.yearHiredColumn;
                    deptIDColumn = form.deptIDColumn;
                    dataStartRow = form.dataStartRow;
                }
                else
                {
                    return;
                }
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (.xls, .xlsx)|*.xlsx;*.xls",
                FilterIndex = 1,
                Multiselect = false
            };

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var loadForm = new LoadingSplash();
                loadForm.Show();
                Hide();

                var thread = new Thread(() =>
                {
                    var application = new Excel.Application();
                    var workbook = application.Workbooks.Open(openFileDialog.FileName);
                    var worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
                    object misValue = Missing.Value;

                    var dataCurrentRow = dataStartRow;

                    try
                    {
                        var newDepartments = new List<Department>();

                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("First pass of two - " + (dataCurrentRow - dataStartRow) + "/? rows processed"))));

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            string deptIDString = deptID.ToString();
                            if (!db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)) && !newDepartments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                            {
                                newDepartments.Add(new Department()
                                {
                                    ID_DEPARTMENT = deptID.ToString()
                                });
                            }

                            dataCurrentRow++;
                        }

                        loadForm.Invoke((new Action(() => loadForm.updateLabel("Saving changes to database"))));

                        db.Departments.AddRange(newDepartments);
                        db.SaveChanges();

                        var totalRows = dataCurrentRow - dataStartRow;
                        dataCurrentRow = dataStartRow;
                        var newAverageSalaries = new List<New_Associate_Professor_Average_Salary>();
                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            var averageSalary = worksheet.Range[(averageSalaryColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            var yearHired = worksheet.Range[yearHiredColumn + dataCurrentRow].Value2;

                            string deptIDString = deptID.ToString();
                            var dept = db.Departments.First(s => s.ID_DEPARTMENT.Equals(deptIDString));

                            newAverageSalaries.Add(new New_Associate_Professor_Average_Salary()
                            {
                                AVERAGE_SALARY = (decimal)averageSalary,
                                ID_DEPARTMENT = dept.ID_DEPARTMENT,
                                YEAR = (int)yearHired
                            }
                                );
                            dataCurrentRow++;
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("Second pass of two - " + (dataCurrentRow - dataStartRow) + "/" + totalRows + " rows processed"))));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Import Failed: " + ex.Message);
                    }

                    workbook.Close(true, misValue, misValue);
                    application.Quit();

                    ReleaseObject(worksheet);
                    ReleaseObject(workbook);
                    ReleaseObject(application);

                    loadForm.Invoke(new Action(() => { loadForm.Close(); }));
                    Invoke(new Action(Show));
                });
                thread.Start();
            }
        }
    }
}
