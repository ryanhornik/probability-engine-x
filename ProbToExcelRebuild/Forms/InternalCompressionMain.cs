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
        public InternalCompressionMain()
        {
            InitializeComponent();
        }

        private UniversityModel db = new UniversityModel();
       
        /*private void Calculate(int RecentYears,double Kvalue,double avg_Merit_raises, double avg_num_merit_raise, double avg_num_merit_raises_prof)
        {

           
            var Recently_Hired_assis_Prof = db.New_Associate_Professor_Average_Salary.Where(s => s.YEAR>=DateTime.Today.Year-RecentYears);
            double AverageProfSalarySum;
            foreach (var prof in Recently_Hired_assis_Prof)
                //  double AverageProfSalarySum=  Recently_Hired_assis_Prof.Select(s=>(double) s.AVERAGE_SALARY).Aggregate((a,b)->a + b);

                AverageProfSalarySum += (double) prof.AVERAGE_SALARY;

            double avgTotal = AverageProfSalarySum / Recently_Hired_assis_Prof.Count();

            double n=  DateTime.Today.Year-RecentYears;
            double K = Math.Pow(Kvalue,n);
            double adjusted_assoc_prof_median = ((AverageProfSalarySum * K) + 7000) * (avg_Merit_raises / avg_num_merit_raise);


            double adjusted_median_prof = ((adjusted_assoc_prof_median + 10000) * (avg_Merit_raises / avg_num_merit_raises_prof));


            double compression1 = 



        }*/
    }
}
