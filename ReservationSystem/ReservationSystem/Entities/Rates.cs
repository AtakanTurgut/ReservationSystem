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
    
    public partial class Rates
    {
        public int RateId { get; set; }
        public string RateName { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public string Symbol { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        public virtual Statuses Statuses { get; set; }
    }
}
