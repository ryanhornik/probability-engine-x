using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ProbabilityToExcel
{
    public partial class MainWindow : Form
    {
        ProbabilityToExcel.ProbAppDataSet db = new ProbAppDataSet();

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
                loadExcelData(openFileDialog.OpenFile());
            }
        }

        private void loadExcelData(Stream fileStream)
        {
            Console.Write("TODO: Add actual processing");
        }
        
    }
}
