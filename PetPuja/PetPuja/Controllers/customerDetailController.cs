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
using System.Web.Http.Cors;

namespace PetPuja.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerDetailController : ApiController
    {
        CustomerRegistrationDataImplementation customerDetailImp = new CustomerRegistrationDataImplementation();
        [Route("api/customerDetail")]
        [HttpPost]
        public string PostCustomer(CustomerAndAddressAndContactAndRole customerDetail)
        {
            var userName = customerDetailImp.PostCustomerDetails(customerDetail);
            return userName;
        }

        [Route("api/customerDetail")]
        [HttpGet]
        public string GetCustomer(string username, string password)
        {
            var userId = customerDetailImp.GetCustomerDetails(username, password);
            return userId.ToString();
        }
    }
}
