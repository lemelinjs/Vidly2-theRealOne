using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{

    public class CustomersController : Controller
    {
        // Consulter la base de données
        private ApplicationDbContext _context;

        //Initialiser dans le constructeur
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // Puisque le contenu de la base de données est jetable on devra en disposer
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            // Pour accéder aux valeurs de l'objet MembershipType on doit l'inclure
            // Il faut mettre en entete using System.Data.Entity
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            // SingleOrDefault ne renvoi qu'un élément dans la séquence ou une valeur par défaut si vide
            // Dans notre cas il renvoi le parametre attendu.
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                 return View(customer);
            }

           
        }
    }
    
}