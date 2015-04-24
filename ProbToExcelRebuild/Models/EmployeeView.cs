namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeView")]
    public partial class EmployeeView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_EMPLOYEE { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "money")]
        public decimal TOTAL_SALARY { get; set; }

        public string UNIVERSITY_NAME { get; set; }

        [StringLength(10)]
        public string ID_DEPARTMENT { get; set; }

        public string JOB_TITLE_NAME { get; set; }
    }
}
