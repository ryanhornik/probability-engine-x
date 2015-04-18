using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityToExcel.Models
{
    public class DemographicData
    {
        [Key, ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
