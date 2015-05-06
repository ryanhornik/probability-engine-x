namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialty_Code
    {
        public Specialty_Code()
        {
            Per_Job_Per_Department = new HashSet<Per_Job_Per_Department>();
        }

        [Key]
        [StringLength(50)]
        public string ID_CODE { get; set; }

        public string ID_DEPARTMENT { get; set; }

        public double WEIGHT { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Per_Job_Per_Department> Per_Job_Per_Department { get; set; }
    }
}
