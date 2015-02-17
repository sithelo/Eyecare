using System.Web.Routing;
using eyecare.web.App_Start;

namespace eyecare.web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes); 
        }

       
    }
}