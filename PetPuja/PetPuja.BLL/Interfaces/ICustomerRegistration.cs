using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPuja.DAL.Context;
using PetPuja.Models;

namespace PetPuja.BLL.Interfaces
{
    interface ICustomerRegistration
    {
        string PostCustomerDetails(CustomerAndAddressAndContactAndRole customerDetail);

        long GetCustomerDetails(string username, string password);
    }
}
