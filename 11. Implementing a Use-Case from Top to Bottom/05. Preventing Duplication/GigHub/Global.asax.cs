using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We are goint to implement the logic for preventing same attendance inserted to the database
 * In AttendancesController.Attend() put the logic for guarding the attendance, if the attendance already exists
 * return bad request
 * 
 * Test: make an api call to insert the attendance as before, the you will get
 *       error message "The attendance already exists." in response body
 * 
 * Look at:
 * • AttendancesController.cs -> Attend()
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
