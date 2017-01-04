using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.ViewModels
{
    public class IndexMovieViewModel
    {
        public IEnumerable<Movie> Movies {get; set;}
       // public int Id { get; set; }

    }
}