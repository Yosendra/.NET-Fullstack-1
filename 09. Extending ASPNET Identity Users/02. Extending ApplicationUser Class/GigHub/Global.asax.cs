using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * Add "Name" property in ApplicationUser class
 * Then "Add-Migration AddNameToApplicationUser", then "Update-Database" in PM console
 * 
 * Check the AspNetUsers table, check the "Name" column
 * Fill that column with any name you want, eg: John Doe
 * 
 * In the Index.cshtml, display the name, not the username
 * 
 * Look at:
 * • ApplicationUser.cs
 * • HomeController.cs -> Index.cshtml
 * • 202403250456501_AddNameToApplicationUser.cs
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
