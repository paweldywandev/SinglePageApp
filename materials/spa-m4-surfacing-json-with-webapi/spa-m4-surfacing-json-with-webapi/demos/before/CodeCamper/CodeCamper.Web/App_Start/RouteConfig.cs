using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

// ReSharper disable RedundantArgumentName

namespace CodeCamper.Web
{
    public class RouteConfig
    {
        public static string ControllerOnly = "ApiControllerOnly";
        public static string ControllerAndId = "ApiControllerAndIntegerId";
        public static string ControllerAction = "ApiControllerAction";

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // This is the default route that a "File | New MVC 4 " project creates.
            // (I changed the name, removed the defaults, and added the constraints)
            routes.MapHttpRoute(
                name: ControllerAndId,
                routeTemplate: "api/{controller}/{id}",
		defaults: new { id = RouteParameter.Optional }
            );

            //Commented this out because we wont be using MVC views
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

        }
    }
}