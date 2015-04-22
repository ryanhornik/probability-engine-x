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
    public partial class Tier1ManualEntry : Form
    {
        public Tier1ManualEntry()
        {
            InitializeComponent();
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
            //DepartmentID.SelectedIndex = 0;
            //JobTitleID.SelectedIndex = 0;
        }
    }
}
