using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* We want to limit the access to Add a Gig form only accessible for Artist
 * Decorate the Create() action method in GigsController with attribute [Authorize]
 * 
 * Test: access the "Add a Gig" view through menu, you will be redirected to Login page 
 * 
 * Register through register page
 * user1@domain.com
 * User1#123
 * 
 * Test: after register or login, access the "Add a Gig" view through menu. The page become accessible
 * 
 * Look at:
 * • GigsController.cs
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
