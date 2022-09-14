using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index ()
        {
            var escuela = new Escuela();
            escuela.AñoFundación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Dirección = "Avd Siempre Viva";
            escuela.Ciudad = "Bogotá";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}