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
        UniversityEntities db = new UniversityEntities();

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



            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadExcelData(openFileDialog.FileName);
            }
        }

        private void LoadExcelData(String filePath)
        {
            var application = new Excel.Application();
            var workbook = application.Workbooks.Open(filePath);
            var worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
            object misValue = Missing.Value;

            var jobTitleColumn = "B";
            var proposedDistSalaryColumn = "Q";
            var deptIDColumn = "AA";
            var deptNameColumn = "Z";
            var dataStartRow = 7;

            while (!worksheet.Range[proposedDistSalaryColumn + dataStartRow].Value2.ToString().Equals("")) // Will be empty when the last row is reached
            {
                var jobTitle = worksheet.Range[jobTitleColumn + dataStartRow].Value2.ToString();
                var proposedDistSalary = worksheet.Range[proposedDistSalaryColumn + dataStartRow].Value2.ToString();
                var deptID = worksheet.Range[deptIDColumn + dataStartRow].Value2.ToString();
                var deptName = worksheet.Range[deptNameColumn + dataStartRow].Value2.ToString();

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
        
    }
}
