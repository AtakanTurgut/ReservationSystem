//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationSystem.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Missions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Missions()
        {
            this.Employees = new HashSet<Employees>();
        }
    
        public int MissionId { get; set; }
        public string MissionName { get; set; }
        public int DepartmentId { get; set; }
        public int StatusId { get; set; }
    
        public virtual Departments Departments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual Statuses Statuses { get; set; }
    }
}
