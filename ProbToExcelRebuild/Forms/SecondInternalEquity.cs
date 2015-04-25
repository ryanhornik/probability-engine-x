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
    public partial class SecondInternalEquity : Form
    {
        UniversityModel db = new UniversityModel();

        public SecondInternalEquity()
        {
            InitializeComponent();
        }

        private void SecondInternalEquity_Load(object sender, EventArgs e)
        {
            List<object[]> allrows = new List<object[]>();
            foreach (var title in db.Job_Title)
            {
                if (title.Per_Job_Per_Department.Count > 0)
                {
                    double uhWeighted = 0;
                    double t1Weighted = 0;
                    foreach (var code in title.Per_Job_Per_Department)
                    {
                        if (code.Specialty_Code.Department == null)
                        {
                            t1Weighted += (double) code.AVERAGE_SALARY * code.Specialty_Code.WEIGHT;
                        }
                        else
                        {
                            uhWeighted += (double) code.AVERAGE_SALARY * code.Specialty_Code.WEIGHT;
                        }
                    }
                    var row = new object[4];
                    row[0] = title.JOB_TITLE_NAME;
                    row[1] = t1Weighted;
                    row[2] = uhWeighted;
                    row[3] = t1Weighted/uhWeighted;
                    allrows.Add(row);
                }
            }
            foreach (var row in allrows)
            {
                secondInternalEquityGrid.Rows.Add(row);
            }
            
        }
    }
}
