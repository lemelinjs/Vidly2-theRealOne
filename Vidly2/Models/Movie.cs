using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
	// POCO - Plain Old CLR OBJECT - Présente l'état et le comportement de l'application.
    public class Movie
	{
		// états
        public int Id { get; set; }
        public string Name { get; set; }
    }
}