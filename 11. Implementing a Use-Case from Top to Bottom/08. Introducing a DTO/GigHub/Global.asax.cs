using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We make a certain mistake before when writing this:
 *   $.post("/api/attendances", gigId)
 * We will correct it with this:
 *   $.post("/api/attendances", { gigId })
 * Because of that, we are going to create AttendanceDto under Dto folder 
 * to receive that gigId from that post request sended by jQuery
 * 
 * Data Transfer Object (DTO) is an architectural pattern
 * to send data accross processes
 * 
 * Use AttendanceDto as parameter in AttendancesController.Attend()
 * 
 * Test: make a request to the api through clicking going button, 
 * 
 * Look at:
 * • HomeController.cs -> Index.cshtml
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
