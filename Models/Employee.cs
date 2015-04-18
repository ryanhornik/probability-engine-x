using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityToExcel.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public int TotalSalary()
        {
            return Salaries.Sum(salary => salary.SalaryAmmount);
        }

        public int UniversityId { get; set; }
        public virtual University University { get; set; }

        public int JobTitleId { get; set; }
        public virtual JobTitle JobTitle { get; set; }

        public string DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual DemographicData DemographicData { get; set; }

        public virtual List<Salary> Salaries { get; set; } 
    }
}
