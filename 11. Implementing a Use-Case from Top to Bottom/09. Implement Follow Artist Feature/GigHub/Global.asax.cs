using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Implement following artist feature
 * Check everything under "following artist feature" comment in the file mentioned below
 * 
 * After modify "Following.cs", "ApplicationUser.cs", "ApplicationDbContext.cs"
 *  Add-Migration AddFollowing
 *  Update-Database
 *  
 * After that, we create the API for Following named "FollowingsController"
 * Put the logic for following in FollowingsController.Follow()
 * 
 * Now in the Index.cshtml of HomeController
 * We put some class in html element and javascript code to sending api request
 * to FollowiingControllers through ajax
 * 
 * Look at:
 * • Following.cs
 * • ApplicationUser.cs
 * • ApplicationDbContext.cs
 * • 202403260912153_AddFollowing.cs
 * • FollowingsController.cs -> Follow()
 * • HomeController.cs -> Index.cshtml
*/

namespace GigHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
