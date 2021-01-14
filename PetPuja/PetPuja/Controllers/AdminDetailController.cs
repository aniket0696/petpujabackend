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
    public class AdminDetailController : ApiController
    {
        AdminloginDataImplementation adminDetailImp = new AdminloginDataImplementation();

        [Route("api/adminDetail")]
        [HttpGet]
        public string GetAdmin(string username, string password)
        {
            var userId = adminDetailImp.GetAdminDetails(username, password);
            return userId.ToString();
        }
    }
}
