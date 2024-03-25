using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * CSS Positioning
 * An element with relative position allows us to absolutely position its children
 * 
 * Style the position relative to <li> element for gigs list, and etc. 
 * (Look at the markup and the the css we applied under "Page-level styles" comment)
 * 
 * Look at:
 * • HomeController.cs -> Index.cshtml
 * • Site.css
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
