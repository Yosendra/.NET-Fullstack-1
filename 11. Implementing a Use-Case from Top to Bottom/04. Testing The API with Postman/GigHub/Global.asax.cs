using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Install extension "Tabbed Postman - Rest Client" in the browser (we use chrome here)
 * the extension is used to test our api
 * 
 * After installing, hit this endpoint "POST /api/attendances" with request body -> 2 (text) through that extension
 * Don't forget to include the request header "Content-Type: application/json"
 * make sure you are in login state because we have put [Authorize] attribute on the AttendancesController
 * 
 * Test: send the POST request to the same exact content like before, now the response will be an exception
 *       because we try to insert duplicate key, remember we cannot insert the same attendance twice
 *       (composite key: UserId, GigId in Attendance table)
 * 
 * Look at:
 * • 
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
