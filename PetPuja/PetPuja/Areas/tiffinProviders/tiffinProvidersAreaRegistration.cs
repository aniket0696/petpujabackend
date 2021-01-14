using System.Web.Mvc;

namespace PetPuja.Areas.tiffinProviders
{
    public class tiffinProvidersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "tiffinProviders";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "tiffinProviders_default",
                "tiffinProviders/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}