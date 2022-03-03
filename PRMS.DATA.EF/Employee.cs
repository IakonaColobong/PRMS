//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRMS.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Firearms = new HashSet<Firearm>();
            this.Trainings = new HashSet<Training>();
            this.Vehicles = new HashSet<Vehicle>();
        }
    
        public int EmployeeId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Badge { get; set; }
        public Nullable<System.DateTime> Date_Of_Hire { get; set; }
        public Nullable<System.DateTime> Date_of_Termination { get; set; }
        public string Pay_Rate_Hourly { get; set; }
        public string Title { get; set; }
        public string Promotion_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Firearm> Firearms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Training> Trainings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
