using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ProbToExcelRebuild.Models;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbToExcelRebuild.Forms
{
    public partial class InternalCompressionMain : Form
    {
        private UniversityModel db = new UniversityModel();

        public InternalCompressionMain()
        {
            InitializeComponent();
        }
       
        private void Calculate(int recentYears, double k,double dAssociate, double lAssociate, double dFull, double lFull)
        {
            k = Math.Pow(k, recentYears);

            var avgRecentHires =(double) db.New_Associate_Professor_Average_Salary
                    .Where(s => s.YEAR >= DateTime.Today.Year - recentYears).Average(s => s.AVERAGE_SALARY);

            var adjustedMedianAssociate = (avgRecentHires*k + 7000)*Math.Pow(dAssociate, lAssociate);
            adjMedAss.Text = adjustedMedianAssociate.ToString();

            var adjustedMedianFull = (adjustedMedianAssociate + 10000)*Math.Pow(dFull, lFull);
            adjMedFull.Text = adjustedMedianFull.ToString();

            var ASSOCIATE_PROFESSOR = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals("ASSOCIATE PROFESSOR"));
            var FULL_PROFESSOR = db.Job_Title.First(s => s.JOB_TITLE_NAME.Equals("PROFESSOR"));

            var actualMedianAssociate = ASSOCIATE_PROFESSOR.CalculateAverages().Median;
            var compressionRatioAssociate = adjustedMedianAssociate/actualMedianAssociate;
            actMedAss.Text = actualMedianAssociate.ToString();
            crAss.Text = compressionRatioAssociate.ToString();

            var actualMedianFull = FULL_PROFESSOR.CalculateAverages().Median;
            var compressionRatioFull = adjustedMedianFull/actualMedianFull;
            actMedFull.Text = actualMedianFull.ToString();
            crFull.Text = compressionRatioFull.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(
                Convert.ToInt32(yearsTextBox.Text),
                Convert.ToDouble(kTextBox.Text),
                Convert.ToDouble(dAssociateTextBox.Text),
                Convert.ToDouble(lAssociateTextBox.Text),
                Convert.ToDouble(dFullTextBox.Text),
                Convert.ToDouble(lFullTextBox.Text)
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
