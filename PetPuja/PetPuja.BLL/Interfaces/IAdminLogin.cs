using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPuja.BLL.Interfaces
{
    interface IAdminLogin
    {
        long GetAdminDetails(string username, string password);
    }
}
