using System.Web.Mvc;

namespace PetPuja.Areas.deliveryBoys
{
    public class deliveryBoysAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "deliveryBoys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "deliveryBoys_default",
                "deliveryBoys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}