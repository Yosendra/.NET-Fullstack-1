using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * Add dropdown list in _LoginPartial.cshtml
 * Look at bootstrap website, look for the navbar component, copy paste the dropdown markup only
 * 
 * Insight:
 * Currently we are using Bootstrap v5.3.3 (https://getbootstrap.com/docs/5.3/components/dropdowns/), 
 * when checking the documentation for dropdown component
 * It explain that we need to use popper.js in order to be able to use the dropdown menu, 
 * so we need to download and save popper.min.js (https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js)
 * under Scripts folder in our project. Then in BundleConfig we need to register it to the bundle. It is a must to render
 * popper.min.js first before rendering bootstrap.js so bootstrap can use popper.js in its dropdown component implementation.
 * 
 * Add a little styling for dropdown in Site.css
 * 
 * Look at:
 * • _LoginPartial.cshtml
 * • popper.min.js
 * • BundleConfig.cs
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
