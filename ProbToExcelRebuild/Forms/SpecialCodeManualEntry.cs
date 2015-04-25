using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbToExcelRebuild.Models;

namespace ProbToExcelRebuild.Forms
{
    public partial class SpecialCodeManualEntry : Form
    {
        private UniversityModel db = new UniversityModel();

        public SpecialCodeManualEntry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void JobTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string idcode;            
            //need to add jobTitle
            //need to get average Salary for Tier 1

            idcode = SpecialtyCodeTextBox.Text.ToString();

            Specialty_Code id;
            if (db.Specialty_Code.Any(s => s.ID_CODE.Equals(idcode)))
            {
                id = db.Specialty_Code.First(s => s.ID_CODE.Equals(idcode));
            }
            else
            {
                id = new Specialty_Code()
                {
                    ID_CODE = idcode
                };
            }
            db.Specialty_Code.Add(id);
            db.SaveChanges();


        }

        private void UpdateIdByIdGridView()
        {
            var rowCount = SpecialtyGridView.Rows.Count;
            for (var i = rowCount - 1; i >= 0; i--)
            {
                SpecialtyGridView.Rows.RemoveAt(i);
            }
            foreach (var s in db.Specialty_Code)
            {
                var row = new object[0];
                row[0] = s.ID_CODE;
                SpecialtyGridView.Rows.Add(row);
            }
        }

        private void SpecialtyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SpecialCodeManualEntry_Load(object sender, EventArgs e)
        {
            UpdateIdByIdGridView();
        }
    }
}
