using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Pas la plus reccommandée - voir attribute routing un peu plus bas pour un meilleur contrôle.
            // routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new
            //    {
            //        controller = "Movies",
            //        action = "ByReleaseDate"
            //    },
            //    new { year = @"\d{4}", month = @"\d{2}" }// On aurait pu mettre year = @"2015|1026" pour contraindre le choix
            //    );

            //Attribute routing - le permettre
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
