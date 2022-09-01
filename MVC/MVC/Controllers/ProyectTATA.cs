using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProyectTATA : Controller
    {
        public IActionResult Index()
        {
            var comida = rotiseria();
            return View(comida);

        }
        public IActionResult ELTATA(int id)
        {
            var comida= rotiseria().FirstOrDefault(x => x.id == id);

            return View(comida);

        }
        public IActionResult gracias()
        {
            return View();
        }
        [NonAction]
        public List<ProyectTata> rotiseria()
        {
            return new List<ProyectTata>
            {
                new ProyectTata()
                {
                    id=1,
                    producto="Hamburguesa",
                    detalle="(pan,carne,lechuga,tomate,jamon,queso,huevo y adereso)",                   
                    precio=700
                },
               new ProyectTata()
                {
                    id=2,
                    producto="Lomito",
                    detalle="(pan,carne,lechuga,tomate,jamon,queso,huevo y adereso)",                   
                    precio=1300
                },
               new ProyectTata()
                {
                    id=3,                    
                    producto="Milanesa",
                    detalle="(pan,carne,lechuga,tomate,jamon,queso,huevo y adereso)",
                    precio=1000
                },
            };

        }
    }

}
