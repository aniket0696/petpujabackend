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
    public class DeliveryBoyDetailController : ApiController
    {
        DeliveryBoyRegistrationDataImplimentation deliveryBoyDetailImp = new DeliveryBoyRegistrationDataImplimentation();
        [Route("api/deliveryBoyDetail")]
        public string PostDeliveryBoy(DeliveryBoyAndAddressAndContactAndRole deliveryBoyDetail)
        {
            var userName = deliveryBoyDetailImp.PostDeliveryBoyDetails(deliveryBoyDetail);
            return userName;
        }

        [Route("api/deliveryBoyDetail")]
        [HttpGet]
        public string GetDeliveryBoy(string username, string password)
        {
            var userId = deliveryBoyDetailImp.GetDeliveryBoyDetails(username, password);
            return userId.ToString();
        }
    }


}
