using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Modify the Sign-Up form by adding Name input field
 * Because we have added a new column in AspNetUsers table
 * 
 * Add "Name" property in RegisterViewModel
 * In Register.cshtml, add Name input field
 * In AccountController.Register() (POST), assign name property of ApplicationUser object with Name property from model 
 * 
 * Test: Run the app, register a new user
 *       Check in AspNetUsers table if the new user is inserted into this table
 * 
 * Look at:
 * • RegisterViewModel.cs
 * • AccountController.cs -> Register.cshtml, Register() (POST)
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
