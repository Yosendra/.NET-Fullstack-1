using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * There are many kind of attack we need to know as a Web Developer
 * like SQL Injection, XSS (Cross-Site Scripting), CSRF (Cross-Site Request Forgery), etc
 * Now we want to prevent CSRF attack on Add a Gig form by using anti-forgery token in Create.cshtml
 * 
 * Put this statement "Html.AntiForgeryToken();" inside the form.
 * In target form which is in GigsController.Create() (POST), decorate that action method with [ValidateAntiForgeryToken] attribute
 * 
 * Test: run the application, go to the Add a Gig form, inspect element on the form.
 *       Check if there is a hidden input element named "__RequestVerificationToken" in the form.
 *       If you want to test it in server-side level, change the value of the token to any value,
 *       then fill the form with valid data, then submit the form. 
 *       There will be an exception of CRSF attack because we have decorated our target action method
 *       with [ValidateAntiForgeryToken] attribute
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
