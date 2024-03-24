using System;
using System.Linq;
using System.Web.Mvc;
using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            var artistId = User.Identity.GetUserId();
            //var user = _context.Users.Single(u => u.Id == artistId);
            var dateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time));
            //var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);
            var genreId = viewModel.Genre;
            var venue = viewModel.Venue;

            var gig = new Gig
            {
                ArtistId = artistId,
                DateTime = dateTime,
                GenreId = genreId,
                Venue = venue,
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}