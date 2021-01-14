using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.Models
{
    public class TiffinProviderDetails
    {
        public long tiffinProviderID { get; set; }
        public string tiffinProviderName { get; set; }
        public string tiffinProviderEmail { get; set; }
        public string restaurantName { get; set; }
        public long contact_no { get; set; }

        public string tiffinProviderUsername { get; set; }
        public string tiffinProviderPassword { get; set; }
        public Nullable<int> statusID { get; set; }
        public Nullable<int> roleID { get; set; }
        public string tiffinProviderImage { get; set; }
        public long addressID { get; set; }
        public Nullable<int> houseNo { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public Nullable<int> zipcode { get; set; }
        public string stateName { get; set; }
        public string country { get; set; }

    }
}
