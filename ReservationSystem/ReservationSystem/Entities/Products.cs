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
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.ProductMovements = new HashSet<ProductMovements>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> ProductCategoryId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<byte> Kdv { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string Descriptions { get; set; }
    
        public virtual ProductCategories ProductCategories { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual Units Units { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMovements> ProductMovements { get; set; }
    }
}
