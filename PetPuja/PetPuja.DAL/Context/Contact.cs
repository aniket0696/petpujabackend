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
    
    public partial class Contact
    {
        public long contactID { get; set; }
        public Nullable<long> customerID { get; set; }
        public Nullable<long> tiffinProviderID { get; set; }
        public Nullable<long> deliveryBoyID { get; set; }
        public long contact_no { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual DeliveryBoy DeliveryBoy { get; set; }
        public virtual TiffinProvider TiffinProvider { get; set; }
    }
}
