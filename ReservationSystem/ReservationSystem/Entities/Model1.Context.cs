﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelDbEntities : DbContext
    {
        public HotelDbEntities()
            : base("name=HotelDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cases> Cases { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Missions> Missions { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<ProductMovements> ProductMovements { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
    
        public virtual ObjectResult<ChartRoomStatus_Result> ChartRoomStatus()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChartRoomStatus_Result>("ChartRoomStatus");
        }
    }
}
