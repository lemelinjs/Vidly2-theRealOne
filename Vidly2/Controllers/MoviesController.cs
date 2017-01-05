using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // Consulter la base de données
        private ApplicationDbContext _context;

        //Initialiser dans le constructeur
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // Puisque le contenu de la base de données est jetable on devra en disposer
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //Le point d'interrogation pour le int est pour le rendre optionnel
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movie);
            }
        }

        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }

       
        //Une route par attribut
        [Route ("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}