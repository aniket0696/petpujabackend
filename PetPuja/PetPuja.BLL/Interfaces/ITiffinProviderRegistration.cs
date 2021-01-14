using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPuja.Models;

namespace PetPuja.BLL.Interfaces
{
    interface ITiffinProviderRegistration
    {
        string PostTiffinProviderDetails(TiffinProviderAndAddressAndContactAndRole tiffinProviderDetail);

        long GetTiffinProviderDetails(string username, string password);
    }
}
