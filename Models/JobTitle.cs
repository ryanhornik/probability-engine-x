using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityToExcel.Models
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }

        public string JobTitleName { get; set; }

        public virtual List<Employee> Employees { get; set; } 
    }
}
