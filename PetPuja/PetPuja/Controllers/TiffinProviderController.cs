using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PetPuja.Models;
using PetPuja.BLL;
using PetPuja.BLL.Interfaces;
using PetPuja.BLL.Implementation;
using PetPuja.DAL;
using PetPuja.DAL.Context;
using System.Web.Http.Cors;

namespace PetPuja.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TiffinProviderController : ApiController
    {
        TiffinProviderImplementation tiffin = new TiffinProviderImplementation();

        [HttpGet]
        [Route("api/TiffinProvider/getTiffinProvider/{id}")]
        public TiffinProviderDetails GetAllTiffinProvider(long id)
        {
            TiffinProviderDetails details = tiffin.GetTiffinProviderProfile(id);
            return details;
        }

        [HttpPut]
        [Route("api/TiffinProvider/updateTiffinProvider/{id}")]
        [ResponseType(typeof(void))]
        public void UpdateTiffinProvider(long id, TiffinProviderDetails tiffinProvider)
        {

            tiffin.UpdateTiffinProvider(id,tiffinProvider);

        }

        [HttpGet]
        [Route("api/TiffinProvider/getMyMenu/{id}")]
        public List<TiffinProviderMenu> GetTiffinMenuList(long id)
        {
            List <TiffinProviderMenu> list= tiffin.GetMyMenu(id);
            
            return list;
        }
        [HttpGet]
        [Route("api/TiffinProvider/getPendingMenu/{id}")]
        public List<TiffinProviderMenu> GetTiffinPendingMenuList(long id)
        {
            List<TiffinProviderMenu> list = tiffin.GetMyMenu(id);

            return list;
        }

        [HttpGet]
        [Route("api/TiffinProvider/getDeclainedMenu/{id}")]
        public List<TiffinProviderMenu> GetTiffinDeclainedMenuList(long id)
        {
            List<TiffinProviderMenu> list = tiffin.GetMyMenu(id);

            return list;
        }

        [HttpPut]
        [Route("api/TiffinProvider/updateTiffinMenu/{id}")]
        [ResponseType(typeof(void))]
        public void UpdateTiffinProviderMenu(long id, TiffinProviderMenu tiffinMenu)
        {

            tiffin.UpdateTiffinMenu(id, tiffinMenu);

        }

        [HttpGet]
        [Route("api/TiffinProvider/getTiffinFeedback/{id}")]
        public List<TiffinProviderFeedback> GetTiffinFeedback(long id)
        {
            List<TiffinProviderFeedback> list = tiffin.GetTiffinFeedback(id);

            return list;
        }

        [HttpGet]
        [Route("api/TiffinProvider/getTiffinOrderHistory/{id}")]
        public List<TiffinOrders> GetTiffinOrderHistory(long id)
        {
            List<TiffinOrders> list = tiffin.GetOrderHistory(id);

            return list;
        }

        [HttpGet]
        [Route("api/TiffinProvider/getTiffinCurrentOrders/{id}")]
        public List<TiffinOrders> GetTiffinCurrentOrders(long id)
        {
            List<TiffinOrders> list = tiffin.GetTiffinCurrentOrders(id);

            return list;
        }
        [HttpPost]
        [Route("api/TiffinProvider/addMenu/{id}")]
        public void Post(long id,[FromBody] TiffinProviderMenu newMenuItem)
        {
            tiffin.AddMenu(id, newMenuItem);            
        }

        [HttpPut]
        [Route("api/TiffinProvider/deregisterTiffinProvider/{id}")]
        [ResponseType(typeof(void))]
        public void DeregisterTiffinProvider(long id)
        {

            tiffin.DeregisterTiffinMenu(id);

        }

    }
}
