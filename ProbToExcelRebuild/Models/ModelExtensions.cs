using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbToExcelRebuild.Models
{
    public partial class UniversityModel
    {
        public Averages CalculateAverages()
        {
            var avg = new Averages();
            var sal = Employees.Sum(imp => imp.TOTAL_SALARY);
            var count = Employees.Count();
            var arr = Employees.ToArray();

            avg.mean = (double)(sal / count);

            if (count % 2 == 0)
            {
                avg.median = ((double)(arr[count / 2].TOTAL_SALARY + arr[count / 2 - 1].TOTAL_SALARY)) / 2;
            }
            else
            {
                avg.median = (double)Employees.ToArray()[count / 2].TOTAL_SALARY;
            }

            if (count % 4 == 0)
            {
                avg.IQR1 = ((double)(arr[count / 4].TOTAL_SALARY + arr[count / 4 - 1].TOTAL_SALARY)) / 2;
                avg.IQR3 = ((double)(arr[3 * count / 4].TOTAL_SALARY + arr[3 * count / 4 - 1].TOTAL_SALARY)) / 2;
            }
            else
            {
                avg.IQR1 = (double)Employees.ToArray()[count / 4].TOTAL_SALARY;
                avg.IQR3 = (double)Employees.ToArray()[3 * count / 4].TOTAL_SALARY;
            }

            return avg;
        }
    }

    public partial class University : Averageable
    {
        public override string ToString()
        {
            return UNIVERSITY_NAME;
        }
    }

    public partial class Job_Title : Averageable
    {
        public override string ToString()
        {
            return JOB_TITLE_NAME;
        }
    }

    public partial class Department : Averageable
    {
        public override string ToString()
        {
            return ID_DEPARTMENT;
        }
    }

    public abstract class Averageable
    {
        public virtual ICollection<Employee> Employees { get; set; }

        public Averages CalculateAverages()
        {
            var avg = new Averages();
            var sal = Employees.Sum(imp => imp.TOTAL_SALARY);
            var count = Employees.Count;
            var arr = Employees.ToArray();

            if (count == 0)
            {
                return avg;
            }

            avg.mean = (double)(sal / count);

            if (count % 2 == 0)
            {
                avg.median = ((double)(arr[count / 2].TOTAL_SALARY + arr[count / 2 - 1].TOTAL_SALARY)) / 2;
            }
            else
            {
                avg.median = (double)Employees.ToArray()[count / 2].TOTAL_SALARY;
            }

            if (count % 4 == 0)
            {
                avg.IQR1 = ((double)(arr[count / 4].TOTAL_SALARY + arr[count / 4 - 1].TOTAL_SALARY)) / 2;
                avg.IQR3 = ((double)(arr[3 * count / 4].TOTAL_SALARY + arr[3 * count / 4 - 1].TOTAL_SALARY)) / 2;
            }
            else
            {
                avg.IQR1 = (double)Employees.ToArray()[count / 4].TOTAL_SALARY;
                avg.IQR3 = (double)Employees.ToArray()[3 * count / 4].TOTAL_SALARY;
            }

            return avg;
        }
    }

    public class Averages
    {
        public double mean { get; set; }
        public double median { get; set; }
        public double IQR1 { get; set; }
        public double IQR3 { get; set; }

        public Averages()
        {
            mean = 0;
            median = 0;
            IQR1 = 0;
            IQR3 = 0;
        }
    }
}
