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
    public partial class SelectUniversity : Form
    {
        public University SelectedUniversity;
        public bool FromFile;

        private UniversityModel db = new UniversityModel();

        public SelectUniversity()
        {
            InitializeComponent();
        }

        private void SelectUniversity_Load(object sender, EventArgs e)
        {
            UniversityDropDown.DropDownStyle = ComboBoxStyle.DropDown;
            UniversityDropDown.Items.AddRange(db.Universities.ToArray());
        }

        //Accept Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (FromFile)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            var uni = UniversityDropDown.SelectedItem;
            University castedUni;
            if (uni != null)
            {
                castedUni = (University)uni;
            }
            else
            {
                castedUni = new University()
                {
                    UNIVERSITY_NAME = UniversityDropDown.Text
                };
                db.Universities.Add(castedUni);
                db.SaveChanges();
            }
            SelectedUniversity = castedUni;
            DialogResult = DialogResult.OK;
            Close();
        }

        //Cancel Button
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FromFile = fromFileCheckBox.Checked;
            UniversityDropDown.Enabled = !FromFile;
            UniversityDropDown.BackColor = (FromFile) ? SystemColors.ControlDark : SystemColors.Window;
        }
    }
}
