using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
//using System.Web.SessionState;
using System.Web.SessionState;

namespace WebApplicationWebFormsTry
{
    public class Global : HttpApplication
    {
        protected void Application_PostAuthorizeRequest()
        {
            HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
            //HttpContext.Current.

            //HttpContext.Current.Session = Session;

            //HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Default); == null

            //if (IsWebApiRequest())
            //{
            //    HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
            //}
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}