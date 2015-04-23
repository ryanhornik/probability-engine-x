using System;
using System.Linq;
using System.Windows.Forms;
using ProbabilityToExcel.Models;

namespace ProbabilityToExcel
{
    public partial class SelectUniversity : Form
    {
        private UniversityEntities db = new UniversityEntities();

        public University SelectedUniversity { get; set; }

        public SelectUniversity()
        {
            InitializeComponent();
        }

        private void SelectUniversity_Load(object sender, EventArgs e)
        {
            db.Universities.Add(new University() {UNIVERSITY_NAME = "University of Houston"});
            db.SaveChanges();

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
