using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* In Create.cshtml, define Gig as the model for the view
 * In the same view, we are going to create a form for add gig
 * 
 * Look at:
 * • Create.cshtml
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
