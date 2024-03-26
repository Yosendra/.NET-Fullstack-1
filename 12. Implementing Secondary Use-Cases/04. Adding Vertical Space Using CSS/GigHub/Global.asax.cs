using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * if you notice the heading and gig list have little space
 * We want to give it more space
 * 
 * In Site.css, we create styling this .voffset selector  
 * 
 * Put that css class on ul.gigs tag on Gigs.cshtml view
 * 
 * Look at:
 * • Site.css
 * • Gigs.cshtml
*/

namespace GigHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
