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
            PopulateJobTitleDropDown();
            PopulateDepartmentIDDropDown();
        }

        void PopulateJobTitleDropDown()
        {

            //******************** IMPORTANT *********************
            //need to change this connection for your computer.
            //Click on the DB in Server Explorer and copy and paste it into the below. Make sure you use "\\" instead pf "\" when putting folder path.
            string connection = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TDICK\\Desktop\\Stuff\\LearningOnMyOwn\\ProbApp\\probtoexcel\\DBProbApp.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT JOB_TITLE_NAME FROM Job_Title";
            SqlConnection db = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, db);
            SqlDataReader myReader;
            
            try
            {
                db.Open();
                myReader = cmd.ExecuteReader();
                JobTitleComboBox.Items.Clear();
                while(myReader.Read())
                {
                    string sName = myReader.GetString(0);
                    JobTitleComboBox.Items.Add(sName);
                }
                db.Close();
                db.Dispose();

                //used this to see if data was read from DB
               /* string msg = "SUCCESS!";
                string cap = "Form Closing";
                var result = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
            }
            catch(Exception)
            {
                string msg = "Failure!";
                string cap = "Form Closing";
                var result = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //db.Close();
            

        }
        //When user hits the Enter button the following happens
        private void EnterButton_Click(object sender, EventArgs e)
        {
            //******************** IMPORTANT *********************
            //need to change this connection for your computer.
            //Click on the DB in Server Explorer and copy and paste it into the below. Make sure you use "\\" instead pf "\" when putting folder path.
            string connection = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TDICK\\Desktop\\Stuff\\LearningOnMyOwn\\ProbApp\\probtoexcel\\DBProbApp.mdf;Integrated Security=True;Connect Timeout=30";
            string jobTitle = JobTitleComboBox.Items.ToString();
            string department = DepartmentIDComboBox.Items.ToString();
            string query1 = "INSERT INTO Job_Title (JOB_TITLE_NAME) VALUES(" + "'" + jobTitle + "'" + ")";
            string query2 = "INSERT INTO Department (DEPARTMENT_NAME) VALUES("+ "'" + department + "'" + ")";
            SqlConnection db = new SqlConnection(connection);
            SqlConnection db1 = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query1, db);
            SqlCommand cmd1 = new SqlCommand(query2, db1);
            SqlDataReader dr;

            try
            {
                db.Open();
                dr = cmd.ExecuteReader();
                dr = cmd1.ExecuteReader();
                MessageBox.Show("saved");
                
                while(dr.Read())
                {

                }

            }
            catch(Exception)
            {
                MessageBox.Show("Failed");
            }
       
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
            JobTitleComboBox.Items.Clear();
            DepartmentIDComboBox.Items.Clear();
            //DepartmentIDTextBox.Clear();
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

        private void PopulateDepartmentIDDropDown()
        {
            //******************** IMPORTANT *********************
            //need to change this connection for your computer.
            //Click on the DB in Server Explorer and copy and paste it into the below. Make sure you use "\\" instead pf "\" when putting folder path.
            string connection = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TDICK\\Desktop\\Stuff\\LearningOnMyOwn\\ProbApp\\probtoexcel\\DBProbApp.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT DEPARTMENT_NAME FROM Department";
            SqlConnection db = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, db);
            SqlDataReader myReader;

            try
            {
                db.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(0);
                    DepartmentIDComboBox.Items.Add(sName);
                }
                //used this to see if data was read from DB
                /* string msg = "SUCCESS!";
                 string cap = "Form Closing";
                 var result = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 */
            }
            catch (Exception)
            {
                string msg = "Failure!";
                string cap = "Form Closing";
                var result = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void DepartmentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JobTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I'm an idiot...
            //PopulateJobTitleDropDown();
        }
    }
}
