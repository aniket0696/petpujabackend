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
    public class TiffinProviderDetailController : ApiController
    {
        TiffinProviderRegistrationDataImplimentation tiffinProviderDetailImp = new TiffinProviderRegistrationDataImplimentation();
        [Route("api/tiffinProviderDetail")]
        public string PostTiffinProvider(TiffinProviderAndAddressAndContactAndRole tiffinProviderDetail)
        {
            var userName = tiffinProviderDetailImp.PostTiffinProviderDetails(tiffinProviderDetail);
            return userName;
        }

        [Route("api/tiffinProviderDetail")]
        [HttpGet]
        public string GetTiffinProviderDetail(string username, string password)
        {
            var userId = tiffinProviderDetailImp.GetTiffinProviderDetails(username, password);
            return userId.ToString();
        }
    }
}
