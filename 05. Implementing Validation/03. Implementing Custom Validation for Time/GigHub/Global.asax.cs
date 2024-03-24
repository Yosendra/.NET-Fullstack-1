using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * Create a custom class attribute named "ValidTime" under ViewModels folder
 * Inherit to ValidationAttribute class to make this class become custom attribute class
 * 
 * Use ValidTime as data annotation for Time property in GigFormViewModel class 
 * 
 * Test: Add a Gig with all value 1 in all input
 * 
 * Look at:
 * • ValidTime.cs
 * • GigFormViewModel.cs
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
