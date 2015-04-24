namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class New_Associate_Professor_Average_Salary
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID_DEPARTMENT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YEAR { get; set; }

        [Column(TypeName = "money")]
        public decimal AVERAGE_SALARY { get; set; }

        public virtual Department Department { get; set; }
    }
}
