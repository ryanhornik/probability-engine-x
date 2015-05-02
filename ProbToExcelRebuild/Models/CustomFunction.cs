namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomFunction")]
    public partial class CustomFunction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CUSTOM_FUNCTION { get; set; }

        [Required]
        public string FUNCTION { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME { get; set; }
    }
}
