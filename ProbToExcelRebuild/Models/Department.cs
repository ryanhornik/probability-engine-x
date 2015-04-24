namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            New_Associate_Professor_Average_Salary = new HashSet<New_Associate_Professor_Average_Salary>();
            Specialty_Code = new HashSet<Specialty_Code>();
        }

        [Key]
        [StringLength(10)]
        public string ID_DEPARTMENT { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<New_Associate_Professor_Average_Salary> New_Associate_Professor_Average_Salary { get; set; }

        public virtual ICollection<Specialty_Code> Specialty_Code { get; set; }
    }
}
