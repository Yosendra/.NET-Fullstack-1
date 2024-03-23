using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* When generating solution, choose template for ASP.NET Web Applicaiton (.NET Framework)
 * Choose the MVC template, don't forget to choose the authentication to Individual Account
 * This will include Identity package for our login feature
 * 
 * This is optional, you can install these extensions in your Visual Studio to improve your development experience:
 * (in Extensions ribbon -> Manage Extensions...)
 * • Productivity Power Tools
 * • The Essentials
*/

namespace GigHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
