using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.Models
{
    public class TiffinProviderFeedback
    {
        public Nullable<long> ordersID { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public Nullable<int> rating { get; set; }

        public string comment { get; set; }
        public string menuName { get; set; }
        public string menuImage { get; set; }
        public Nullable<System.DateTime> orderDateTime { get; set; }
        public Nullable<System.DateTime> deliveryDateTime { get; set; }

    }
}
