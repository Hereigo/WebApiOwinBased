using System.Web.Http;

namespace WebApiOwinBased
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AllCustomers",
                routeTemplate: "customers",
                defaults: new { controller = "Customers", action = "Get" }
                );
        }
    }
}