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
    
    public partial class Admin
    {
        public long adminID { get; set; }
        public string adminName { get; set; }
        public string adminEmail { get; set; }
        public string adminAddress { get; set; }
        public string adminUsername { get; set; }
        public string adminPassword { get; set; }
        public Nullable<int> roleID { get; set; }
    
        public virtual RoleTable RoleTable { get; set; }
    }
}
