using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * (notice migration is failed now)
 * 
 * To use Fluent API we need to override OnModelCreating() method in ApplicationDbContext class
 * inside that overrided method, put your configuration for Attendance table
 * We will disable the cascade delete here
 * 
 * Replace the failed migration file before by putting this command in PM console:
 *   Add-Migration AddAttendance -force
 *   Update-Database
 * 
 * Look at:
 * • ApplicationDbContext.cs -> OnModelCreating()
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
