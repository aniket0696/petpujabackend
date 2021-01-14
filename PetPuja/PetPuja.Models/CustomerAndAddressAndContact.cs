﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetPuja.Models
{
    public class CustomerAndAddressAndContact
    {
        public long customerID { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public Nullable<long> addressID { get; set; }
        public string customerUsername { get; set; }
        public string customerPassword { get; set; }
        public Nullable<int> statusID { get; set; }
        public Nullable<int> roleID { get; set; }

        //public long addressID { get; set; }
        public Nullable<int> houseNo { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public Nullable<int> zipcode { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        //public long contactID { get; set; }
        //public Nullable<long> customerID { get; set; }
        public Nullable<long> tiffinProviderID { get; set; }
        public Nullable<long> deliveryBoyID { get; set; }
        public long contact_no { get; set; }
    }
}