namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University")]
    public partial class University
    {
        public University()
        {
            Employees = new HashSet<Employee>();
            Per_Job_Per_Department = new HashSet<Per_Job_Per_Department>();
        }

        [Key]
        public int ID_UNIVERSITY { get; set; }

        [Required]
        public string UNIVERSITY_NAME { get; set; }

        public bool IS_TIER_1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Per_Job_Per_Department> Per_Job_Per_Department { get; set; }
    }
}
