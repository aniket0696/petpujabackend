using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.Models
{
    public class TiffinProviderMenu
    {
        public long menuID { get; set; }
        public Nullable<long> tiffinProviderID { get; set; }
        public string menuDescription { get; set; }
        public string menuName { get; set; }
        public Nullable<decimal> price { get; set; }
        public string menuImage { get; set; }
        public string category { get; set; }
        public Nullable<int> statusID { get; set; }

    }
}
