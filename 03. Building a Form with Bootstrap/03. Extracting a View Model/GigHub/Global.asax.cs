using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Continue the form creation in Create.cshtml
 * We are introduced with a concept called View Model
 * View Model is a class purely for presentation, it is not a part of the domain
 * 
 * Create folder named "ViewModels"
 * Add view model class named "GigFormViewModel" under that folder
 * 
 * Back to Create view, change its model to GigFormViewModel
 * 
 * Look at:
 * • GigFormViewModel.cshtml
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
