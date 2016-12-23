//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parcel()
        {
            this.ShippingAddresses = new HashSet<ShippingAddress>();
        }
    
        public int ParcelId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> FranchiseId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> Dimensions { get; set; }
        public Nullable<int> ParcelWeight { get; set; }
        public Nullable<decimal> Costs { get; set; }
        public Nullable<byte> DeliveryType { get; set; }
        public string ParcelStatus { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    
        public virtual FranchiseRate FranchiseRate { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }
    }
}
