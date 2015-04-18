using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityToExcel.Models
{
    public class University
    {
        [Key]
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }

        public virtual List<Employee> Employees { get; set; } 
    }
}
