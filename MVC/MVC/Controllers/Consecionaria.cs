using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class Consecionaria : Controller
    {

        public IActionResult Index()
        {
            var autos = obtenermarcas();

            return View(autos);
        }

        public IActionResult Formulario(int id)
        {
            
            var auto = obtenermarcas().FirstOrDefault(x => x.ID == id);


            return View(auto);
        }

        [NonAction]
        public List<Consecionarias> obtenermarcas()
        {
            return new List<Consecionarias>
            {
                new Consecionarias()
                {
                    ID = 1,
                    Marca = "Fiat",
                    Modelo = "Palio",
                    Año = 2000

                },
                new Consecionarias()
                {
                    ID = 2,
                    Marca = "Toyota",
                    Modelo = "Corolla",
                    Año = 2010

                },
                new Consecionarias()
                {
                    ID = 3,
                    Marca = "Audi",
                    Modelo = "A1",
                    Año = 2012

                }
            };
        }
    }
}
