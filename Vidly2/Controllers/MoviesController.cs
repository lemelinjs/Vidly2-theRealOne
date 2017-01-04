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
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!"};
            //Créer une liste en attendant de travailler avec des bases de données

            var customers = new List<Customer>
            {
                new Customer { Name = "Michel Lemelin"},
                new Customer { Name = "Nathaniel Lemelin"}
            };

            //Créer un objet viewModel
            var viewModel = new RandomMovieViewModel()
            // Initialiser les clients et les films
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            // Divers méthodes listées dans Fundamentals Cheat Sheet. (R2S10)
            // Return content
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
           // return RedirectToAction("index","Home");
        }

        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }
        //List des films
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        //Le point d'interrogation pour le int est pour le rendre optionnel
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            // Devoir 1
            var movies = GetMovies();
            return View(movies);
        }
        //Une route par attribut
        [Route ("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}