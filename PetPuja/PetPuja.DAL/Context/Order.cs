//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetPuja.DAL.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Bookings = new HashSet<Booking>();
            this.DeliveryBoyFeedbacks = new HashSet<DeliveryBoyFeedback>();
            this.TiffinFeedbacks = new HashSet<TiffinFeedback>();
        }
    
        public long ordersID { get; set; }
        public Nullable<long> tiffinProviderID { get; set; }
        public Nullable<long> customerID { get; set; }
        public Nullable<long> deliveryBoyID { get; set; }
        public Nullable<int> statusID { get; set; }
        public Nullable<System.DateTime> orderDateTime { get; set; }
        public Nullable<System.DateTime> deliveryDateTime { get; set; }
        public Nullable<long> addressID { get; set; }
        public Nullable<long> paymentID { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DeliveryBoy DeliveryBoy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryBoyFeedback> DeliveryBoyFeedbacks { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual StatusTable StatusTable { get; set; }
        public virtual TiffinProvider TiffinProvider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiffinFeedback> TiffinFeedbacks { get; set; }
    }
}
