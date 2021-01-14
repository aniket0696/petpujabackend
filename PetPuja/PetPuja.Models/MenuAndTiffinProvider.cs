using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.Models
{
    public class MenuAndTiffinProvider
    {
        public long menuID { get; set; }
        public Nullable<long> tiffinProviderID { get; set; }
        public string menuDescription { get; set; }
        public string menuName { get; set; }
        public Nullable<decimal> price { get; set; }
        public string menuImage { get; set; }
        public string category { get; set; }
        public Nullable<int> statusID { get; set; }


        //public long tiffinProviderID { get; set; }
        public string tiffinProviderName { get; set; }
        public string tiffinProviderEmail { get; set; }
        public string restaurantName { get; set; }
        public Nullable<long> addressID { get; set; }
        public string tiffinProviderUsername { get; set; }
        public string tiffinProviderPassword { get; set; }
        //public Nullable<int> statusID { get; set; }
        public string status { get; set; }
        public Nullable<int> roleID { get; set; }
        public string tiffinProviderImage { get; set; }
    }
}
