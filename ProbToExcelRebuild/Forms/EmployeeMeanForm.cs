using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbToExcelRebuild.Forms
{
    public partial class EmployeeMeanForm : Form
    {
        public EmployeeMeanForm()
        {
            InitializeComponent();
        }

        private void EmployeeMeanForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(MeanComboBox.SelectedItem.Equals("Department"))
            {
                MessageBox.Show("Department Success");
            }
            else if(MeanComboBox.SelectedItem.Equals("Job Title"))
            {
                MessageBox.Show("Job Title Success");
            }
            else if(MeanComboBox.SelectedItem.Equals("University"))
            {
                MessageBox.Show("University Success");
            }
            else
                MessageBox.Show("Failure");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainWindow x = new MainWindow();
            this.Hide();
            x.Show();
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
