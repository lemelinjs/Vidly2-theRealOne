using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        //Consulter la base de donnée
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            // SingleOrDefault ne renvoi qu'un élément dans la séquence ou une valeur par défaut si vide
            // Dans notre cas il renvoi le parametre attendu.
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                 return View(customer);
            }

           
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Michel Lemelin" },
                new Customer { Id = 2, Name = "Stéphanie St-Onge" }
            };
        }
    }
    
}