using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPuja.Models;

namespace PetPuja.BLL.Interfaces
{
    interface IDeliveryBoyRegistration
    {
        string PostDeliveryBoyDetails(DeliveryBoyAndAddressAndContactAndRole deliveryBoyDetail);

        long GetDeliveryBoyDetails(string username, string password);
    }
}
