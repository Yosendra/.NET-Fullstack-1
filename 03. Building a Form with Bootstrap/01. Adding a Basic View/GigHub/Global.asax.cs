using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Add new controller named "GigsController"
 * Add Create.cshtml view in GigsController
 * 
 * Add a menu "Add a Gig" on navigation bar in _Layout.cshtml
 * 
 * Look at:
 * • GigsController.CS
 * • Create.cshtml
 * • _Layout.cshtml
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
