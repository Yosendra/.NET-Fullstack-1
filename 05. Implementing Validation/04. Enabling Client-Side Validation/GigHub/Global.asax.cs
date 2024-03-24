using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * Understand how bundle works in BundleConfig
 * At Create.cshtml, in most bottom line, add a section script named "scripts"
 * Embed the script for jquery validation
 * 
 * Test: Add a Gig with all empty data. Check the Network tab of Browser Dev Tool. No request is sended because of client validation
 * 
 * Unfortunately this client-side feature only works for built-in data annotation like [Required], [StringLength()], etc
 * For custom data annotation like [ValidTime] and [FutureDate] is not supported in client-side validation, only supported in server-side
 * We need to manually implement them if you want it to support in client-side
 * 
 * Look at:
 * • BundleConfig.cs
 * • Create.cshtml
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
