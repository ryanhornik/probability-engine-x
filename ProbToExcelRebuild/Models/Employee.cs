namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int ID_EMPLOYEE { get; set; }

        public int ID_UNIVERSITY { get; set; }

        public int ID_JOB_TITLE { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_DEPARTMENT { get; set; }

        [Column(TypeName = "money")]
        public decimal TOTAL_SALARY { get; set; }

        public virtual Department Department { get; set; }

        public virtual Job_Title Job_Title { get; set; }

        public virtual University University { get; set; }
    }
}
