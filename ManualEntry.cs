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
            double temp;
            if(EmployeeIDTextBox.Equals(null) || JobTitleComboBox.Equals(null) || TotalSalaryTextBox.Equals(null) || DepartmentIDTextBox.Equals(null))
            {
                //using this to catch and make sure in the TotalSalaryTextBox is a double
                if(double.TryParse(TotalSalaryTextBox.Text, out temp))
                {

                }
                else
                {
                    //displays an error box if it's not a double
                    MessageBox.Show("Please Enter a valid amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //using this to catch and make sure in the TotalSalaryTextBox is a double
                if (double.TryParse(TotalSalaryTextBox.Text, out temp))
                {

                }
                else
                {
                    //displays an error box if it's not a double
                    MessageBox.Show("Please Enter a valid amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
