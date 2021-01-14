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
    
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            this.Bookings = new HashSet<Booking>();
            this.TiffinFeedbacks = new HashSet<TiffinFeedback>();
        }
    
        public long menuID { get; set; }
        public Nullable<long> tiffinProviderID { get; set; }
        public string menuDescription { get; set; }
        public string menuName { get; set; }
        public Nullable<decimal> price { get; set; }
        public string menuImage { get; set; }
        public string category { get; set; }
        public Nullable<int> statusID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual StatusTable StatusTable { get; set; }
        public virtual TiffinProvider TiffinProvider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiffinFeedback> TiffinFeedbacks { get; set; }
    }
}