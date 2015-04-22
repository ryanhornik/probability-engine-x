using System;
using System.Linq;
using System.Windows.Forms;
using ProbabilityToExcel.Models;

namespace ProbabilityToExcel
{
    public partial class SelectUniversity : Form
    {
        private DBProbAppEntities db = new DBProbAppEntities();

        public University SelectedUniversity { get; set; }

        public SelectUniversity()
        {
            InitializeComponent();
        }

        private void SelectUniversity_Load(object sender, EventArgs e)
        {
            UniversityDropDown.DropDownStyle = ComboBoxStyle.DropDown;
            UniversityDropDown.Items.AddRange(db.Universities.ToArray());
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
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
    }
}
