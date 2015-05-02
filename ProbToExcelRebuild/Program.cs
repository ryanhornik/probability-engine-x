using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ProbToExcelRebuild.Forms;
using Application = System.Windows.Forms.Application;

namespace ProbToExcelRebuild
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }

    public static class HelperClass
    {
        public static void ExportToExcel(DataGridView dgv)
        {
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            var wb = app.Workbooks.Add((Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet));
            var ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                MessageBox.Show("Excel worksheet could not be created");
                return;
            }
            for (var i = 'A'; i - 'A' < dgv.ColumnCount; i++)
            {
                var j = 1;
                ws.Range[i + "" + j].Value2 = dgv.Columns[i - 'A'].HeaderText;

                for (j += 1; j < dgv.RowCount; j++)
                {
                    ws.Range[i + "" + j].Value2 = dgv.Rows[j].Cells[i - 'A'].Value;
                }
            }
        }
    }
}
