namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Per_Job_Per_Department
    {
        [Key]
        public int ID_AVERAGE_SALARY { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_CODE { get; set; }

        public int ID_UNIVERSITY { get; set; }

        public int ID_JOB_TITLE { get; set; }

        [Column(TypeName = "money")]
        public decimal AVERAGE_SALARY { get; set; }

        public virtual Job_Title Job_Title { get; set; }

        public virtual Specialty_Code Specialty_Code { get; set; }

        public virtual University University { get; set; }
    }
}
