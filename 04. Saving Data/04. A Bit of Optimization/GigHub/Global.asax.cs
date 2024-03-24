using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * User1#123
 * 
 * If you notice, before, we get the artist through the database
 * then get the genre through database again
 * then the last save the gig to the database
 * Total 3 times we query the database. We can optimize it
 * 
 * If you look at Gig class, it has Artist property with type ApplicationUser
 * and Genre with type Genre
 * They are called Navigation Property in the domain class
 * 
 * To prevent fetching Artist and Genre to database
 * We are going to add a foreign key property to the gig
 * They are ArtistId, GenreId
 * So in the Create() action method, there is no need to pick Genre and Artist to the database
 * Just use the GenreId given by the GigFormViewModel sended from the form and User.Identity.GetUserId() for the ArtistId
 * 
 * Add GenreId, ArtistId property in the Gig class
 *  Add-Migration AddForeignKeyPropertiesToGig
 *  Update-Database
 * 
 * Check the Gigs table for the foreign key column, is it already affected by migration
 * 
 * Now change the implementation for assigning Artist and Genre to the Gig object
 * instead of assigning to Artist and Genre property, now assign the ArtistId and GenreId
 * also we can delete the query data to genre and artist, since we use ArtistId and GenreId to
 * store Genre and Artist
 * 
 * Test: again try to save Gig data trough Add a Gig form
 * 
 * Look at:
 * • Gig.cs
 * • GigController.cs -> Create() (POST)
 * • 202403240836375_AddForeignKeyPropertiesToGig.cs
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
