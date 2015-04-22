using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace ProbabilityToExcel
{
    public partial class ManualEntry : Form
    {
        
        public ManualEntry()
        {
            InitializeComponent();
        }
        //When user hits the Enter button the following happens
        private void EnterButton_Click(object sender, EventArgs e)
        {

            //string sqlInsertSalary = "INSERT INTO Salary ";




            //a temp variable to check if the value entered for total salary is a double
           // double temp;
            //checks if there are any null values in the text fields
            /*
            if(EmployeeIDTextBox.Equals(null) || JobTitleComboBox.Equals(null) || SalaryBox.Equals(null) || DepartmentIDTextBox.Equals(null))
            {
                /*
                //using this to catch and make sure in the Salary data is a double
                if(double.TryParse(SalaryBox., out temp))
                {
                    //if it is a double do the following:
                }
                else
                {
                    //displays an error box if it's not a double
                    MessageBox.Show("Please Enter a valid amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                  */
            //}
        /*
            else
            {
                //using this to catch and make sure in the TotalSalaryTextBox is a double
                if (double.TryParse(SalaryBox.Text, out temp))
                {
                    //if it is a double do the following:
                }
                else
                {
                    //displays an error box if it's not a double
                    MessageBox.Show("Please Enter a valid amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            }
         * */
                
                 
        }
        //If the user hits the cancel button the program goes back to the Main Form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        //Clears the fields in the textfields on the form
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //EmployeeIDTextBox.Clear();
            //JobTitleComboBox.SelectedIndex = 0;
            SalaryBox.Clear();
            DepartmentIDTextBox.Clear();
        }
        //Can delete the bellow 
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Can delete this one too
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DropDownPopulate()
        {
            string sqlQuery = "";
            //string conString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DBProbApp.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlConnection x = new SqlConnection(conString);

        }
    }
}
