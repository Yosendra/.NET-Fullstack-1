using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * We choose Red (#FF4342) and Orange as our application color.
 * We will start by changing the navigation bar color.
 * Inspect element on navigation bar to inspect which element, id, or class we take as selector
 * for styling in css.
 * 
 * After inspecting the "nav" element, I decide to remove class "navbar-dark" and "bg-dark" from it.
 * Now put our custom color in Site.css
 * We are forbided to change the bootstrap.css file, all our custom css styling must be putted in Site.css
 * 
 * Test: Run the application, take a look the background color, the menu color, and the application name color
 * 
 * Look at:
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
