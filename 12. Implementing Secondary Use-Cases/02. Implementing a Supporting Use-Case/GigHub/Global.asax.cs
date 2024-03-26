using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We are going to build "view gig's the user attending" feature
 * Create new action method named "Attending" in GigsCOntoller
 * Create its view page
 * Create view model for that view page. We name it "AttendingVM", we place it under "ViewModels/Gigs" directory
 * Put a hyperlink in the dropdown menu (that "Gigs I'm Going" menu) to direct to the Attending page. The dropdown menu is in _LoginPartial.cshtml
 * 
 * Test: Delete all data in Attendances table for testing purpose
 *       We will check the page when there is not attendances, the add new gig, then check again the attendances page
 * 
 * Look at:
 * • GigController.cs -> Attending(), Attending.cshtml
 * • AttendingVM.cs
 * • _LoginPartial.cshtml
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
