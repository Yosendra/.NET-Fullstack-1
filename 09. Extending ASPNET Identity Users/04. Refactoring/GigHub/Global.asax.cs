using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * In AccountViewModels.cs, there are many classes inside it.
 * We will seperate them into its own file. So it become 1 class, 1 file.
 * For view model class move them to ViewModel folder, then update its namespace
 * 
 * Check ViewModels folder
 * 
 * Re-implement the the using statement of model's view in all .cshtml file which using
 * those changed view model class that we have refactor. (in this case we move them to 
 * their own folder and updating its namespace)
 * 
 * Look at:
 * • 
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
