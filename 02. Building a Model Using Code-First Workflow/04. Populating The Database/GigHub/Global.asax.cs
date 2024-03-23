using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* We are going to populate data for Genres table using Code-First approach
 *  Add-Migration PopulateGenresTable
 * Write the insert query for Genres table in Up method
 * Write the opposite query of up method in down method
 * 
 * Now check the in Genres table
 * 
 * Look at:
 * • 202403232308000_PopulateGenresTable.CS
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
