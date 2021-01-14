using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.Models
{
    public class TiffinProviderAndAddressAndContactAndRole
    {
        public long tiffinProviderID { get; set; }
        public string tiffinProviderName { get; set; }
        public string tiffinProviderEmail { get; set; }
        public Nullable<long> addressID { get; set; }
        public string tiffinProviderUsername { get; set; }
        public string tiffinProviderPassword { get; set; }
        public string restaurantName { get; set; }
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
        public Nullable<long> customerID { get; set; }
        //public Nullable<long> tiffinProviderID { get; set; }
        public Nullable<long> deliveryBoyID { get; set; }
        //public long contact_no { get; set; }
        public long primaryContactNo { get; set; }
        public long secondaryContactNo { get; set; }
    }
}
