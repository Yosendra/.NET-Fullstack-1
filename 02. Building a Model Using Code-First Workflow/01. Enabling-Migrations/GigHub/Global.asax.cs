using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* We are using Code=First approach (the other one is Database-First approach)
 * With EntityFramework package installed, insert this command in Package Manager Console
 *   Enable-Migrations
 *   
 * For the first time, add for the first time because we have domain classes from Identity packages
 * these domain classes from identity package are used for authentication & authorization operation
 * like Register user, Login, etc. Back to PM Console, insert this command:
 *   Add-Migration InitialModel
 * 
 * To affect database every time we do add migration, insert this command PM console:
 *   Update-Database
 *   
 * With current setting of connection string in Web.config, our database location is in App_Data folder
 * To actually see it in Solution Explorer, click on icon "Show All Data" (it is beside "Collapse All" icon)
 * 
 * Double click the database to see the tables generated from Update-Database before
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
