using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* We are goint to create our domain classes of our app
 * Create Gig class under Models folder. (also Genre)
 * 
 * In ApplicationDbContext class, add these properties:
 * • public DbSet<Gig> Gigs { get; set; }
 * • public DbSet<Genre> Genres { get; set; }
 * Then in PM console add migration again:
 *   Add-Migration CreateGigTable 
 *   [or]
 *   Add-Migration CreateGigTable -force 
 *   (if you have already add migration with the same name)
 * Then
 *   Update-Database
 * 
 * Now, check the generated table Gigs and Genres in the database
 * 
 * Look at:
 * • Gig.cs
 * • Genre.cs
 * • ApplicationDbContext.cs
 * • 202403231306475_CreateGigTable.cs
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
