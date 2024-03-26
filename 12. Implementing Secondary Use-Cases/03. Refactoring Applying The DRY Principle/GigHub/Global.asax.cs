using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We will create a single view for Gig display. Put it in Views/Shared directory
 * This view will be used by two action method, they are Homecontroller.Index() & GigsController.Attending()
 * This is what we call DRY (Do not repeat yourself) principle
 * 
 * Put Index.cshtml of HomeController to "Views/Shared" and rename it to Gigs.cshtml
 * Move IndexVM.cs of HomeController to "ViewModels/Shared" and rename it to GigsVM.cs. Add property Heading with string type.
 * 
 * On Gigs.cshtml, change the model to GigsVM
 * 
 * On Homecontroller.Index() & GigsController.Attending(), construct object GigsVM as the view model object for those two action method
 * and change the view location by giving the first argument with view's name, and the second one is the view model object
 * 
 * We can delete AttendingVM file
 * 
 * Test: run the application, visit the home page and attending page to make sure the view run render properly
 * 
 * Look at:
 * • HomeController.cs -> Index()
 * • GigsController.cs -> Attending()
 * • Gigs.cshtml
 * • GigsVM.cs
 * • AttendingVM.cs (Deleted)
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
