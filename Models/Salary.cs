using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityToExcel.Models
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }

        public int SalaryAmmount { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
