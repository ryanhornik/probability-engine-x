//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProbabilityToExcel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demographic_Data
    {
        public Demographic_Data()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int ID_DEMOGRAPHIC_DATA { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
