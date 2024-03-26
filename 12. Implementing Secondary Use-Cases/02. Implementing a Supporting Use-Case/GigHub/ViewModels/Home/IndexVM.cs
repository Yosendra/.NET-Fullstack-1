using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.ViewModels.Home
{
    public class IndexVM
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool IsShowActions { get; set; }
    }
}