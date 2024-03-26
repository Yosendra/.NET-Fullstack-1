using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.ViewModels.Gigs
{
    public class AttendingVM
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool IsShowActions { get; set; }
    }
}