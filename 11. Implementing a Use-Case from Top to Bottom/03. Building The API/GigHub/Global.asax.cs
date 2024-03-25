using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * API Contract
 * POST     /api/attendances
 * {
 *   gigId: {gigId}
 * }
 * 
 * Create API controller named "AttendancesController" under "/Controllers/Api" directory (Notice API controller, not MVC controller)
 * For the first time creating api controller, there will appear readme.txt contain the guide to enable web api, follow the guide.
 * 
 * The guide:

Visual Studio has added the full set of dependencies for ASP.NET Web API 2 to project 'GigHub'. 
The Global.asax.cs file in the project may require additional changes to enable ASP.NET Web API.
1. Add the following namespace references:
    using System.Web.Http;
    using System.Web.Routing;
2. If the code does not already define an Application_Start method, add the following method:
    protected void Application_Start()
    {
    }
3. Add the following lines to the beginning of the Application_Start method:
    GlobalConfiguration.Configure(WebApiConfig.Register);

 * When following the guide, we are asked to install package "Microsoft.AspNet.WebApi.WebHost"
 * 
 * Create action method "Attend" on that api controller
 * We put [FromBody] attribute in before gigId parameter definition, so it will take gigId value only from request body
 * We put [Authorize] attribute in the controller so only the authenticated user can access the controller
 * 
 * Look at:
 * • Global.asax.cs
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
