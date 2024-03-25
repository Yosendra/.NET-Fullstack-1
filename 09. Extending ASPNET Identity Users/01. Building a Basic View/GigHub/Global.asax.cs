using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * We want to replace the homepage with the list of upcoming Gig
 * In HomeController.Index() we will query the list of upcoming Gigs
 * In Index.cshtml, make a simple view for listing all upcoming gigs
 * 
 * Look at:
 * • HomeController.cs -> Index(), Index.cshtml
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
