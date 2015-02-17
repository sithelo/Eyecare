using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eyecare.web.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resources}.axd/{*pathinfo}");
            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Main",
                    action = "Index",
                    id = UrlParameter.Optional
                }
                );
        }
    }
}