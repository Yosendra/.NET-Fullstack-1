using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* We need to add input type for Genre
 * That would be a dropdown list
 * 
 * In Create view, add a dropdown list for Genre
 * In GigsController, populate the view model of Create() action method
 * 
 * But before that we need to construct the object of ApplicationDbContext
 * since we are taking the Genres data which stored in the database
 * 
 * Test: access the add a gig menu
 * 
 * Look at:
 * • Create.cshtml
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
