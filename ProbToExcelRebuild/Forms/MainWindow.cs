using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
                    var totalRows = worksheet.UsedRange.Rows.Count - dataStartRow;
                    object misValue = Missing.Value;
                    loadForm.numOfRows = totalRows;
                    

                    var dataCurrentRow = dataStartRow;

                    try
                    {
                        var newDepartments = new List<Department>();
                        var newJobTitles = new List<Job_Title>();
                        var newEmployees = new List<Employee>();

                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke(new Action(() =>
                                {
                                    loadForm.progressBar1.Value = (((dataCurrentRow - dataStartRow)*50)/totalRows);
                                    loadForm.updateLabel("First pass of two - " + (dataCurrentRow - dataStartRow) + "/"+totalRows+" rows processed");
                                }));
                                

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
                            loadForm.Invoke((new Action(() =>
                                {
                                    loadForm.updateLabel("Second pass of two - " + (dataCurrentRow - dataStartRow) + "/" + totalRows + " rows processed");
                                    loadForm.progressBar1.Value = (((dataCurrentRow - dataStartRow) * 50) / totalRows) +50;
                                })));
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

                    Invoke(new Action(UpdateEmployeeGridView));
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
            ManualEntryEmployee manualForm = new ManualEntryEmployee();
            Hide();
            manualForm.ShowDialog();
            Show();
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
                                AVERAGE_SALARY = (decimal)averageSalary,
                                ID_DEPARTMENT = dept.ID_DEPARTMENT,
                                YEAR = (int)yearHired
                            }
                                );
                            dataCurrentRow++;
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("Second pass of two - " + (dataCurrentRow - dataStartRow) + "/" + totalRows + " rows processed"))));
                        }

                        loadForm.Invoke((new Action(() => loadForm.updateLabel("Saving changes to database"))));

                        db.New_Associate_Professor_Average_Salary.AddRange(newAverageSalaries);
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

                    Invoke(new Action(UpdateNewHireAveragesGridView));
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

            using (var form = new SelectColumnsPerDepartmentPerSpecialCode())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    averageSalaryColumn = form.averageSalaryColumn;
                    specialtyCodeColumn = form.specialtyCodeColumn;
                    jobTitleColumn = form.jobTitleColumn;
                    weightColumn = form.weightColumn;
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
                        var newJobTitles = new List<Job_Title>();
                        var newSpecialtyCodes = new List<Specialty_Code>();

                        while (worksheet.Range[specialtyCodeColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("First pass of two - " + (dataCurrentRow - dataStartRow) + "/? rows processed"))));

                            var jobTitle = worksheet.Range[(jobTitleColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            var specialtyCode = worksheet.Range[specialtyCodeColumn + dataCurrentRow].Value2;

                            var weight = worksheet.Range[weightColumn + dataCurrentRow].Value2;

                            string deptIDString = null;

                            if (deptID != null)
                            {
                                deptIDString = deptID.ToString();
                                if (!db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)) &&
                                    !newDepartments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                                {
                                    newDepartments.Add(new Department()
                                    {
                                        ID_DEPARTMENT = deptID.ToString()
                                    });
                                }
                            }


                            string jobTitleString = jobTitle.ToString();
                            if (!db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)) &&
                                !newJobTitles.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)))
                            {
                                newJobTitles.Add(new Job_Title()
                                {
                                    JOB_TITLE_NAME = jobTitle.ToString()
                                });
                            }

                            string specialtyCodeString = specialtyCode.ToString();
                            if (!db.Specialty_Code.Any(s => s.ID_CODE.Equals(specialtyCodeString)) &&
                                !newSpecialtyCodes.Any(s => s.ID_CODE.Equals(specialtyCodeString)))
                            {
                                newSpecialtyCodes.Add(new Specialty_Code()
                                {
                                    ID_CODE = specialtyCodeString,
                                    ID_DEPARTMENT = deptIDString,
                                    WEIGHT = weight
                                });
                            }

                            dataCurrentRow++;
                        }


                        loadForm.Invoke((new Action(() => loadForm.updateLabel("Saving changes to database"))));

                        db.Departments.AddRange(newDepartments);
                        db.SaveChanges();

                        db.Job_Title.AddRange(newJobTitles);
                        db.SaveChanges();

                        db.Specialty_Code.AddRange(newSpecialtyCodes);
                        db.SaveChanges();

                        var totalRows = dataCurrentRow - dataStartRow;
                        dataCurrentRow = dataStartRow;
                        var newPerJobPerDepartment = new List<Per_Job_Per_Department>();

                        int UHID = db.Universities.First(s => s.UNIVERSITY_NAME.Equals("University of Houston")).ID_UNIVERSITY;
                        int OTHERID = db.Universities.First(s => s.UNIVERSITY_NAME.Equals("Unknown Tier 1")).ID_UNIVERSITY;

                        while (worksheet.Range[specialtyCodeColumn + dataCurrentRow].Value2 != null)
                        {
                            var jobTitle = worksheet.Range[(jobTitleColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            var specialtyCode = worksheet.Range[specialtyCodeColumn + dataCurrentRow].Value2.ToString();

                            var averageSalary = worksheet.Range[averageSalaryColumn + dataCurrentRow].Value2;

                            string jobTitleString = jobTitle.ToString();

                            var jobTitleFromDB =
                                db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobTitleString));
                            var jobTitleID = jobTitleFromDB.ID_JOB_TITLE;


                            newPerJobPerDepartment.Add(new Per_Job_Per_Department()
                            {
                                AVERAGE_SALARY = (decimal)averageSalary,
                                ID_CODE = specialtyCode,
                                ID_JOB_TITLE = jobTitleID,
                                ID_UNIVERSITY = (deptID != null) ? UHID : OTHERID
                            });

                            dataCurrentRow++;
                            loadForm.Invoke((new Action(() => loadForm.updateLabel("Second pass of two - " + (dataCurrentRow - dataStartRow) + "/" + totalRows + " rows processed"))));
                        }

                        loadForm.Invoke((new Action(() => loadForm.updateLabel("Saving changes to database"))));

                        db.Per_Job_Per_Department.AddRange(newPerJobPerDepartment);
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

                    Invoke(new Action(UpdateAverageByJobGridView));
                    loadForm.Invoke(new Action(() => { loadForm.Close(); }));
                    Invoke(new Action(Show));
                });
                thread.Start();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateEmployeeGridView();
            UpdateNewHireAveragesGridView();
            UpdateAverageByJobGridView();
        }

        private void UpdateEmployeeGridView()
        {
            var rowCount = employeeGrid.Rows.Count;
            for (var i = rowCount-1; i >= 0; i--)
            {
                employeeGrid.Rows.RemoveAt(i);
            }
            foreach (var emp in db.EmployeeViews)
            {
                var row = new object[5];
                row[0] = emp.ID_EMPLOYEE;
                row[1] = emp.TOTAL_SALARY.ToString("$000,000.00");
                row[2] = emp.UNIVERSITY_NAME;
                row[3] = emp.ID_DEPARTMENT;
                row[4] = emp.JOB_TITLE_NAME;
                employeeGrid.Rows.Add(row);
            }
        }

        private void UpdateNewHireAveragesGridView()
        {
            var rowCount = newHireAveragesGrid.Rows.Count;
            for (var i = rowCount - 1; i >= 0; i--)
            {
                newHireAveragesGrid.Rows.RemoveAt(i);
            }
            foreach (var sal in db.New_Associate_Professor_Average_Salary)
            {
                var row = new object[3];
                row[0] = sal.AVERAGE_SALARY.ToString("$000,000.00");
                row[1] = sal.ID_DEPARTMENT;
                row[2] = sal.YEAR;
                newHireAveragesGrid.Rows.Add(row);
            }
        }
        
        private void UpdateAverageByJobGridView()
        {
            var rowCount = averageByJobGrid.Rows.Count;
            for (var i = rowCount - 1; i >= 0; i--)
            {
                averageByJobGrid.Rows.RemoveAt(i);
            }
            foreach (var sal in db.Per_Job_Per_Department)
            {
                var row = new object[6];
                row[0] = sal.Specialty_Code.ID_CODE;
                row[1] = sal.Specialty_Code.ID_DEPARTMENT;
                row[2] = sal.Specialty_Code.WEIGHT;
                row[3] = sal.Job_Title.JOB_TITLE_NAME;
                row[4] = sal.University.UNIVERSITY_NAME;
                row[5] = sal.AVERAGE_SALARY.ToString("$000,000.00");
                averageByJobGrid.Rows.Add(row);
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeMeanForm x = new EmployeeMeanForm();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void externalCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalEquity form = new ExternalEquity();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void employeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void averageNewHireDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Add manual entry for new hire averages
        }
        
        private void enterSpecialCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialCodeManualEntry form = new SpecialCodeManualEntry();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void internalCompressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternalCompressionMain form = new InternalCompressionMain();
            Hide();
            form.ShowDialog();
            Show();
        }
        private void secondInternalEquityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondInternalEquity form = new SecondInternalEquity();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void programPEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramPEX form = new ProgramPEX();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
