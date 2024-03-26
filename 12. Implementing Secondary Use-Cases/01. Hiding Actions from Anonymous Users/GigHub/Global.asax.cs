using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * There is still something wrong here. When we don't login, we still can see going to button and follow button on the Gig list page
 * We want to only show them to the authenticated users
 * 
 * Insight: We will group view models file into each folder based on controller whom using it
 *          for example we group all view models class which used in GigControllers into Gigs folder inside 
 *          under ViewModels folder. Currently I will refactor my view models structure file following this
 *          guide.
 * 
 * We will create a view model class to be used by HomeController.cs.Index()
 * Create IndexVM under "ViewModels/Home" directory
 * In HomeController.cs.Index(), construct IndexVM object, then pass it to the View() invocation
 * Now in the Index.cshtml view, change the model binding to the this IndexVM type
 * Give the condition whether to show follow and going button based on IsShowActions property on that Index.cshtml view
 * 
 * Test: check the actions button in gig list when you are on login state and not in login state
 * 
 * Look at:
 * • IndexVM.cs
 * • HomeController.cs -> Index(), Index.cshtml
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
