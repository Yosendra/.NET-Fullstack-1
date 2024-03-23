using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* If we look at Gigs table, at Venue, Genre_Id, Artist_Id columns is nullable.
 * We want to make those column become not nullable. Also we want the venue column type
 * to be NVARCHAR(255) not NVARCHAR(max)
 * 
 * We will override this using data annotation. Another way is using Fluent API.
 * Later we will refactor it later using Fluent API.
 * 
 * In Gig class, we are going to use the necessary attribute like [Required] and [StringLength] in its property
 * Then Add migration, then update database
 * 
 * Now look at the database, check the table definition of Gigs and Genres
 * 
 * Look at:
 * • Gig.cs
 * • Genre.cs
 * • 202403232251588_OverrideConventionsForGigsAndGenres.cs
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
