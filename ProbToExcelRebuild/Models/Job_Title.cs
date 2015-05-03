namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job_Title
    {
        public Job_Title()
        {
            Employees = new HashSet<Employee>();
            Per_Job_Per_Department = new HashSet<Per_Job_Per_Department>();
        }

        [Key]
        public int ID_JOB_TITLE { get; set; }

        [Required]
        public string JOB_TITLE_NAME { get; set; }

        public virtual ICollection<Per_Job_Per_Department> Per_Job_Per_Department { get; set; }
    }
}
