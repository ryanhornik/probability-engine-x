using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ProbToExcelRebuild.Models;
using System.Drawing;
using System.Globalization;

namespace ProbToExcelRebuild.Forms
{
    public partial class MainWindow : Form
    {
        private UniversityModel db = new UniversityModel();

        private DialogResult checkForExcel()
        {
            Process[] pname = Process.GetProcessesByName("Excel");
            if (pname.Length > 0)
            {
                var result = MessageBox.Show("Excel is already running. Automatically close it?"
                    , "Excel Process Detected"
                    , MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (var proc in pname)
                    {
                        proc.Kill();
                    }
                }
                return result;
            }
            return DialogResult.Yes;
        }

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
            University university = null;
            bool FromFile;

            using (var form = new SelectUniversity())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    FromFile = form.FromFile;
                    if (!form.FromFile)
                    {
                        university = form.SelectedUniversity;
                    }

                }
                else
                {
                    return;
                }
            }

            string universityColumn = "X";
            string jobTitleColumn;
            string proposedTotalSalaryColumn;
            string deptIDColumn;
            int dataStartRow;

            using (var form = new SelectColumnsEmployee(FromFile))
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    if (FromFile)
                    {
                        universityColumn = form.uniColumn;
                    }
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

            if (checkForExcel() != DialogResult.Yes)
            {
                return;
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
                    var totalRows = worksheet.UsedRange.Rows.Count - dataStartRow;
                    object misValue = Missing.Value;
                    loadForm.numOfRows = totalRows;


                    var dataCurrentRow = dataStartRow;

                    try
                    {
                        var newDepartments = new List<Department>();
                        var newJobTitles = new List<Job_Title>();
                        var newEmployees = new List<Employee>();
                        var newUniversities = new List<University>();

                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke(new Action(() =>
                                {
                                    loadForm.progressBar1.Value = (((dataCurrentRow - dataStartRow) * 50) / totalRows);
                                    loadForm.progressBar1.CreateGraphics().DrawString((((dataCurrentRow - dataStartRow) * 50) / totalRows) + "%", new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7));
                                }));


                            var jobTitle = worksheet.Range[(jobTitleColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            if (jobTitle != null)
                            {
                                if (FromFile)
                                {
                                    var uniName = worksheet.Range[universityColumn + dataCurrentRow].Value2;
                                    string uniNameString = uniName.ToString();
                                    if (!db.Universities.Any(s => s.UNIVERSITY_NAME.Equals(uniNameString, StringComparison.OrdinalIgnoreCase)) &&
                                        !newUniversities.Any(s => s.UNIVERSITY_NAME.Equals(uniNameString, StringComparison.OrdinalIgnoreCase)))
                                    {
                                        newUniversities.Add(new University()
                                        {
                                            UNIVERSITY_NAME = uniNameString,
                                            IS_TIER_1 = true
                                        });
                                    }
                                }

                                string deptIDString = deptID.ToString().ToUpper();
                                if (!db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)) &&
                                    !newDepartments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                                {
                                    newDepartments.Add(new Department()
                                    {
                                        ID_DEPARTMENT = deptIDString
                                    });
                                }

                                string jobTitleString = jobTitle.ToString().ToUpper();
                                if (!db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)) && !newJobTitles.Any(s => s.JOB_TITLE_NAME.Equals(jobTitleString)))
                                {
                                    newJobTitles.Add(new Job_Title()
                                    {
                                        JOB_TITLE_NAME = jobTitleString
                                    });
                                }
                            }

                            dataCurrentRow++;
                        }

                        db.Departments.AddRange(newDepartments);
                        db.SaveChanges();

                        db.Job_Title.AddRange(newJobTitles);
                        db.SaveChanges();

                        db.Universities.AddRange(newUniversities);
                        db.SaveChanges();

                        dataCurrentRow = dataStartRow;
                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {

                            var jobTitle = worksheet.Range[(jobTitleColumn + dataCurrentRow)].Value2;

                            var proposedTotalSalary = worksheet.Range[proposedTotalSalaryColumn + dataCurrentRow].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            if (jobTitle != null)
                            {
                                string deptIDString = deptID.ToString().ToUpper();
                                Department dept = db.Departments.First(s => s.ID_DEPARTMENT == deptIDString);

                                string jobTitleString = jobTitle.ToString().ToUpper();
                                Job_Title title = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals(jobTitleString));

                                if (FromFile)
                                {
                                    var uniName = worksheet.Range[universityColumn + dataCurrentRow].Value2;
                                    string uniNameString = uniName.ToString();
                                    university = db.Universities.First(s => s.UNIVERSITY_NAME.Equals(uniNameString, StringComparison.OrdinalIgnoreCase));
                                }

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
                            loadForm.Invoke(new Action(() =>
                            {
                                var percentage = Math.Min(((dataCurrentRow - dataStartRow) * 50) / totalRows + 50, 100);
                                loadForm.progressBar1.Value = percentage;
                                loadForm.progressBar1.CreateGraphics()
                                    .DrawString((percentage + "%"), new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7));
                            }));
                        }

                        loadForm.Invoke((new Action(() => loadForm.progressBar1.CreateGraphics().DrawString("Saving changes to database", new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7)))));
                        db.Employees.AddRange(newEmployees);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        new ErrorMessageBox(ex, "Import Failed").ShowDialog();
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
                new ErrorMessageBox(ex, "Unable to release the object").ShowDialog();
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

            if (checkForExcel() != DialogResult.Yes)
            {
                return;
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
                    var totalRows = worksheet.UsedRange.Rows.Count - dataStartRow;

                    var dataCurrentRow = dataStartRow;

                    try
                    {
                        var newDepartments = new List<Department>();

                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            loadForm.Invoke(new Action(() =>
                            {
                                loadForm.progressBar1.Value = (((dataCurrentRow - dataStartRow) * 50) / totalRows);
                                loadForm.progressBar1.CreateGraphics().DrawString((((dataCurrentRow - dataStartRow) * 50) / totalRows) + "%", new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7));
                            }));

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            string deptIDString = deptID.ToString().ToUpper();
                            if (!db.Departments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)) &&
                                !newDepartments.Any(s => s.ID_DEPARTMENT.Equals(deptIDString)))
                            {
                                newDepartments.Add(new Department()
                                {
                                    ID_DEPARTMENT = deptIDString
                                });
                            }

                            dataCurrentRow++;
                        }

                        loadForm.Invoke((new Action(() => loadForm.progressBar1.CreateGraphics().DrawString("Saving changes to database", new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7)))));

                        db.Departments.AddRange(newDepartments);
                        db.SaveChanges();

                        dataCurrentRow = dataStartRow;
                        var newAverageSalaries = new List<New_Associate_Professor_Average_Salary>();
                        while (worksheet.Range[deptIDColumn + dataCurrentRow].Value2 != null)
                        {
                            var averageSalary = worksheet.Range[(averageSalaryColumn + dataCurrentRow)].Value2;

                            var deptID = worksheet.Range[deptIDColumn + dataCurrentRow].Value2;

                            var yearHired = worksheet.Range[yearHiredColumn + dataCurrentRow].Value2;

                            string deptIDString = deptID.ToString().ToUpper();
                            var dept = db.Departments.First(s => s.ID_DEPARTMENT.Equals(deptIDString));

                            newAverageSalaries.Add(new New_Associate_Professor_Average_Salary()
                            {
                                AVERAGE_SALARY = (decimal)averageSalary,
                                ID_DEPARTMENT = dept.ID_DEPARTMENT,
                                YEAR = (int)yearHired
                            }
                                );
                            dataCurrentRow++;
                            loadForm.Invoke(new Action(() =>
                            {
                                var percentage = Math.Min(((dataCurrentRow - dataStartRow) * 50) / totalRows + 50, 100);
                                loadForm.progressBar1.Value = percentage;
                                loadForm.progressBar1.CreateGraphics()
                                    .DrawString((percentage + "%"), new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7));
                            }));
                        }

                        loadForm.Invoke((new Action(() => loadForm.progressBar1.CreateGraphics().DrawString("Saving changes to database", new System.Drawing.Font("Arial", (float)8.25, System.Drawing.FontStyle.Regular), Brushes.Black, new System.Drawing.PointF(loadForm.progressBar1.Width / 2 - 10, loadForm.progressBar1.Height / 2 - 7)))));

                        db.New_Associate_Professor_Average_Salary.AddRange(newAverageSalaries);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        new ErrorMessageBox(ex, "Import Failed").ShowDialog();
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

            #region Preparation
            string Document1SpecialtyCodeColumn;
            string Document1CodeWeightColumn;
            string Document1DepartmentIdColumn;
            int Document1DataRow;

            string Document2SpecialtyCodeColumn;
            string Document2SalaryColumn;
            string Document2JobTitleColumn;
            int Document2DataRow;

            using (var form = new SelectColumnsPerDepartmentPerSpecialCode())
            {
                var selectResult = form.ShowDialog();
                if (selectResult == DialogResult.OK)
                {
                    Document1SpecialtyCodeColumn = form.Document1SpecialtyCodeColumn;
                    Document1CodeWeightColumn = form.Document1CodeWeightColumn;
                    Document1DepartmentIdColumn = form.Document1DepartmentIdColumn;
                    Document1DataRow = form.Document1DataRow;

                    Document2SpecialtyCodeColumn = form.Document2SpecialtyCodeColumn;
                    Document2SalaryColumn = form.Document2SalaryColumn;
                    Document2JobTitleColumn = form.Document2JobTitleColumn;
                    Document2DataRow = form.Document2DataRow;
                }
                else
                {
                    return;
                }
            }

            if (checkForExcel() != DialogResult.Yes)
            {
                return;
            }

            OpenFileDialog document1 = new OpenFileDialog
            {
                Filter = "Excel Files (.xls, .xlsx)|*.xlsx;*.xls",
                FilterIndex = 1,
                Multiselect = false
            };
            var result = document1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            OpenFileDialog document2 = new OpenFileDialog
            {
                Filter = "Excel Files (.xls, .xlsx)|*.xlsx;*.xls",
                FilterIndex = 1,
                Multiselect = false
            };
            result = document2.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }


            var loadForm = new LoadingSplash();
            loadForm.Show();
            Hide();
            #endregion

            var thread = new Thread(() =>
            {
                object misValue = Missing.Value;

                #region Document1Processing
                var application1 = new Excel.Application();
                var workbook1 = application1.Workbooks.Open(document1.FileName);
                var worksheet1 = (Excel.Worksheet)workbook1.Worksheets.Item[1];
                var totalRows1 = worksheet1.UsedRange.Rows.Count - Document1DataRow;

                var dataCurrentRow1 = Document1DataRow - 1; // Have to increment at top of loop

                try
                {
                    var specialCodes = new List<Specialty_Code>();
                    var departments = new List<Department>();

                    while (worksheet1.Range[Document1SpecialtyCodeColumn + (dataCurrentRow1+1)].Value2 != null)
                    {
                        dataCurrentRow1++;
                        loadForm.Invoke(new Action(() =>
                        {
                            loadForm.progressBar1.SetValue(((dataCurrentRow1 - Document1DataRow) * 50) / totalRows1);
                        }));

                        var specialtyCode = worksheet1.Range[Document1SpecialtyCodeColumn + dataCurrentRow1].Value2;
                        var department = worksheet1.Range[Document1DepartmentIdColumn + dataCurrentRow1].Value2;
                        var weight = worksheet1.Range[Document1CodeWeightColumn + dataCurrentRow1].Value2;

                        string specialtyCodeString = specialtyCode.ToString();
                        if (db.Specialty_Code.Any(s => s.ID_CODE.Equals(specialtyCodeString)) ||
                            specialCodes.Any(s => s.ID_CODE.Equals(specialtyCodeString))) { continue; }

                        Department dept;
                        string departmentString = department.ToString().ToUpper();
                        if (db.Departments.All(s => !s.ID_DEPARTMENT.Equals(departmentString)) &&
                            departments.All(s => !s.ID_DEPARTMENT.Equals(departmentString)))
                        {
                            dept = new Department()
                            {
                                ID_DEPARTMENT = departmentString
                            };
                            departments.Add(dept);
                        }
                        else
                        {
                            dept = departments.FirstOrDefault(s => s.ID_DEPARTMENT.Equals(departmentString)) ??
                                   db.Departments.FirstOrDefault(s => s.ID_DEPARTMENT.Equals(departmentString));
                        }

                        specialCodes.Add(new Specialty_Code()
                        {
                            ID_DEPARTMENT = dept.ID_DEPARTMENT,
                            ID_CODE = specialtyCode.ToString(),
                            WEIGHT = Convert.ToDouble(weight.ToString())
                        });

                        
                    }

                    loadForm.Invoke((new Action(() => loadForm.progressBar1.SetValue(50, "Saving changes to the database"))));
                    db.Departments.AddRange(departments);
                    db.SaveChanges();
                    db.Specialty_Code.AddRange(specialCodes);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    new ErrorMessageBox(ex, "Import Failed").ShowDialog();
                }

                workbook1.Close(true, misValue, misValue);
                application1.Quit();

                ReleaseObject(worksheet1);
                ReleaseObject(workbook1);
                ReleaseObject(application1);
                #endregion

                #region Document2Processing
                var application2 = new Excel.Application();
                var workbook2 = application2.Workbooks.Open(document2.FileName);
                var worksheet2 = (Excel.Worksheet)workbook2.Worksheets.Item[1];
                var totalRows2 = worksheet2.UsedRange.Rows.Count - Document2DataRow;

                var dataCurrentRow2 = Document2DataRow;

                try
                {
                    var pjpd = new List<Per_Job_Per_Department>();
                    var jobs = new List<Job_Title>();
                    var codes = new List<Specialty_Code>();

                    while (worksheet2.Range[Document2SpecialtyCodeColumn + dataCurrentRow2].Value2 != null)
                    {
                        loadForm.Invoke(new Action(() =>
                        {
                            loadForm.progressBar1.SetValue(50 + ((dataCurrentRow2 - Document2DataRow) * 50) / totalRows2);
                        }));

                        var salary = worksheet2.Range[Document2SalaryColumn + dataCurrentRow2].Value2;
                        var title = worksheet2.Range[Document2JobTitleColumn + dataCurrentRow2].Value2;
                        var code = worksheet2.Range[Document2SpecialtyCodeColumn + dataCurrentRow2].Value2;

                        Specialty_Code sCode;
                        string codeString = code.ToString();
                        if (!db.Specialty_Code.Any(s => s.ID_CODE.Equals(codeString)) &&
                            !codes.Any(s => s.ID_CODE.Equals(codeString)))
                        {
                            sCode = new Specialty_Code()
                            {
                                ID_CODE = codeString
                            };
                            codes.Add(sCode);
                        }
                        else
                        {
                            sCode = db.Specialty_Code.FirstOrDefault(s => s.ID_CODE.Equals(codeString)) ??
                                    codes.FirstOrDefault(s => s.ID_CODE.Equals(codeString));
                        }

                        Job_Title jt;
                        string titleString = title.ToString().ToUpper();
                        if (!db.Job_Title.Any(s => s.JOB_TITLE_NAME.Equals(titleString)) &&
                            !jobs.Any(s => s.JOB_TITLE_NAME.Equals((titleString))))
                        {
                            jt = new Job_Title()
                            {
                                JOB_TITLE_NAME = titleString
                            };
                            jobs.Add(jt);
                        }
                        else
                        {
                            jt = db.Job_Title.FirstOrDefault(s => s.JOB_TITLE_NAME.Equals(titleString)) ??
                                 jobs.FirstOrDefault(s => s.JOB_TITLE_NAME.Equals((titleString)));
                        }

                        pjpd.Add(new Per_Job_Per_Department()
                        {
                            AVERAGE_SALARY = Convert.ToDecimal(salary.ToString()),
                            ID_CODE = sCode.ID_CODE,
                            Job_Title = jt,
                            ID_UNIVERSITY = db.Universities.First().ID_UNIVERSITY //TODO Figure out how to determine university
                        });

                        dataCurrentRow2++;
                    }

                    loadForm.Invoke((new Action(() => loadForm.progressBar1.SetValue(100, "Saving changes to database"))));
                    db.Specialty_Code.AddRange(codes);
                    db.SaveChanges();
                    
                    db.Job_Title.AddRange(jobs);
                    db.SaveChanges();

                    db.Per_Job_Per_Department.AddRange(pjpd);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    new ErrorMessageBox(ex, "Import Failed").ShowDialog();
                }

                workbook2.Close(true, misValue, misValue);
                application2.Quit();

                ReleaseObject(worksheet2);
                ReleaseObject(workbook2);
                ReleaseObject(application2);
                #endregion

                Invoke(new Action(UpdateAverageByJobGridView));
                loadForm.Invoke(new Action(() => { loadForm.Close(); }));
                Invoke(new Action(Show));
            });
            thread.Start();
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
            for (var i = rowCount - 1; i >= 0; i--)
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
            ManualEntryAverage form = new ManualEntryAverage();
            Hide();
            form.ShowDialog();
            Show();
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

        private void averageSalariesByJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperClass.ExportToExcel(averageByJobGrid);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperClass.ExportToExcel(employeeGrid);
        }

        private void newAverageHireSalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperClass.ExportToExcel(newHireAveragesGrid);
        }
    }
}
