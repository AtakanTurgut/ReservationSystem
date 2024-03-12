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
    
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public System.DateTime StartingDate { get; set; }
        public System.DateTime QuittingDate { get; set; }
        public int DepartmentId { get; set; }
        public int MissionId { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; }
    
        public virtual Departments Departments { get; set; }
        public virtual Missions Missions { get; set; }
        public virtual Statuses Statuses { get; set; }
    }
}
