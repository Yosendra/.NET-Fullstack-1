using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We are going to create realation between Gig and User table (many-to-many)
 * We need intermediary table, we name it "Attendance"
 * So we need to create Attendace class in our domain classes
 * 
 * Create Attendance domain class under Models folder
 * Add Gig and User as the its navigation property
 * 
 * In Attendance, the combination of Gig and User is the primary key
 * This is called composite key because this primary key is consist of 2 columns AttendeeId and GigId
 * Notice the data annotation we use on both property in Attendance class
 * 
 * Add Attendance as property in ApplicationDbContext
 * Add migration, then update database
 * There will be an error due to multiple cascade to Attendance table because of our current tables relationship
 * User -> Gig -> Attendance <- User
 * If we delete User, due to cascade delete, Gig & Attendance will be deleted
 * Because Gig is deleted, it will also delete Attendance
 * See it double cascade on Attendance
 * The solution is to disable cascade delete in one of the relationship
 * We choose to not delete Gig, we will implement cancel flag on Gig instead of permanently deleting it
 * Now, disable the cascade delete on User to Gig relationship, instead of modifying directly the migration file
 * we will use Fluent API mechanism
 * 
 * (notice migration is failed now)
 * 
 * Look at:
 * • Attendance.cs
 * • ApplicationDbContext.cs
 * • 202403251842390_AddAttendance.cs
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
