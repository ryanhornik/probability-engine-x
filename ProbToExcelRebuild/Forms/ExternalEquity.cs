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
    public partial class ExternalEquity : Form
    {
        UniversityModel db = new UniversityModel();

        public ExternalEquity()
        {
            InitializeComponent();
        }

        private void ExternalEquity_Load(object sender, EventArgs e)
        {
            foreach (var title in db.Job_Title)
            {
                var avgUH = (title.Employees.Count(s => s.University.UNIVERSITY_NAME.Equals("University of Houston")) > 0)?
                    title.Employees
                    .Where(s => s.University.UNIVERSITY_NAME.Equals("University of Houston"))
                    .Sum(s => s.TOTAL_SALARY) /
                    title.Employees.Count(s => s.University.UNIVERSITY_NAME.Equals("University of Houston")):0;

                var avgOther = (title.Employees.Count(s => s.University.IS_TIER_1) > 0)?
                    title.Employees
                    .Where(s => s.University.IS_TIER_1)
                    .Sum(s => s.TOTAL_SALARY) /
                    title.Employees.Count(s => s.University.IS_TIER_1):0;

                object[] row = new object[4];
                row[0] = title.JOB_TITLE_NAME;
                row[1] = avgUH;
                row[2] = avgOther;
                row[3] = (avgOther != 0)?avgUH/avgOther:0;
                equityGrid.Rows.Add(row);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            HelperClass.ExportToExcel(equityGrid);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
