using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;


namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View( new Asignatura{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            });
        }
        public IActionResult MultiAsignatura()
        { 
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas",
                                UniqueId= Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                           
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.UtcNow;

            return View("MultiAsignatura", listaAsignaturas);
        
        
    }
  }
}