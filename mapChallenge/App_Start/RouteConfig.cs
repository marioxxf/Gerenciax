using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mapChallenge
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "mapa-acesso",
                "mapa",
                new { controller = "Map", action = "Mapa" }
            );

            routes.MapRoute(
                "locais-registrados",
                "mapa/registrados",
                new { controller = "Map", action = "Registrados" }
            );

            routes.MapRoute(
                "locais-registrar",
                "mapa/registrar",
                new { controller = "Map", action = "Registrar" }
            );

            routes.MapRoute(
                "locais-criar",
                "mapa/criarlocal",
                new { controller = "Map", action = "CriarLocal" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
