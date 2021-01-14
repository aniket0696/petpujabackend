using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.Models
{
    public class TiffinOrders
    {
        public long ordersID { get; set; }
        public Nullable<System.DateTime> orderDateTime { get; set; }
        public Nullable<System.DateTime> deliveryDateTime { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string deliveryBoyName { get; set; }
        public string deliveryBoyEmail { get; set; }
       // public List<TiffinProviderMenu> tiffinProviderMenus { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public Nullable<decimal> billingAmount { get; set; }
    }
}
