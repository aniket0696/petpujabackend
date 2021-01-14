using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetPuja.Models;
using PetPuja.BLL;
using PetPuja.BLL.Interfaces;
using PetPuja.BLL.Implementation;
namespace PetPuja.Controllers
{
    public class AdminController : ApiController
    {
        AdminImplementation ad = new AdminImplementation();
        [Route("api/admin/getcustomer")]
        public List<CustomerAndAddressAndContact> GetCustomer()
        {
            
           
           var l= ad.GetCustomerDetails();
            return l.ToList();
        }

        [Route("api/admin/getallmenus")]
        public List<MenuAndTiffinProvider> GetAllMenuDetails()
        {
            var menulist = ad.GetAllMenu();
            return menulist.ToList();
        }
    }
}
