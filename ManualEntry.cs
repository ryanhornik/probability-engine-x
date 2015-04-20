using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilityToExcel
{
    public partial class ManualEntry : Form
    {
        
        public ManualEntry()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //ManuallyEnterData();
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
            EmployeeIDTextBox.Clear();
            JobTitleComboBox.Items.Clear();
            TotalSalaryTextBox.Clear();
            DepartmentIDTextBox.Clear();
            OutputTextBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
