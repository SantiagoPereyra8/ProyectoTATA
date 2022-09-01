using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class Parametros : Controller
    {
        public ActionResult Index(string nombre, string apellido, int edad)
        {
            var modelo = new Datospers
            {
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad

            };
            return View(modelo);
        }
    }
}
