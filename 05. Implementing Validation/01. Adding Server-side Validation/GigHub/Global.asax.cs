using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * We are going to implement server-side validation for our Add a Gig form
 * In GigFormViewModel properties, we apply some data annotation
 * In Create.cshtml, we put element for validation message below the input text element
 * In GigsController.Create() (POST), add logic for validation checking of view model object
 * 
 * We convert the DateTime property in GigFormViewModel into a method.
 * (because there is an exception when model binding process when empty input for Date and Time submitted in the form
 * exception happen when parsing Date and Time to DateTime property)
 * In the GigsController, assign to assigning DateTime property of Gig become like this "DateTime = viewModel.GetDateTime()"
 * 
 * Look at:
 * • GigFormViewModel.cs
 * • Create.cshtml
 * • GigsController.cs -> Create() (POST)
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
