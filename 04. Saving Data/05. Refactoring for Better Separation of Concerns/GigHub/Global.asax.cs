using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * In you take attention in GigsController.Create(),
 * You make the controller responsible for parsing a string value into DateTime object
 * That's not the responsibility of the controller.
 * Controller should act as a cordinator for the application logic. "What should happen next?"
 * That's the job of the controller.
 * So parsing value is too detail for controller to know.
 * 
 * In the OOP we have a principle called Information Expert
 * That means the class or the object, that has the information, should be the one that will
 * carry that responsibility.
 * 
 * In our case, GigFormViewModel is the class that has those information, so it is GigFormViewModel responsibility
 * to parse the DateTime string
 * 
 * Add "DateTime" at GigFormViewModel
 * Define getter of that property
 * 
 * Test: Add a Gig through the form
 * 
 * Look at:
 * • GigFormViewModel.cs
 * • GigsController.cs -> Create()
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
