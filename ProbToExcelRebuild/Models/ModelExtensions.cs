using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbToExcelRebuild.Models
{
    public partial class University
    {
        public override string ToString()
        {
            return UNIVERSITY_NAME;
        }

        public Averages CalculateAverages()
        {
            var sal = Employees.Sum(imp => imp.TOTAL_SALARY);
            var obj = Employees.Count;
        }

    }
    public class Averages
    {
        public double mean { get; set; }
        public double median { get; set; }
        public double IQR1 { get; set; }
        public double IQR3 { get; set; }

        private Averages()
        {
            mean = 0;
            median = 0;
            IQR1 = 0;
            IQR3 = 0;
        }
    }
}
