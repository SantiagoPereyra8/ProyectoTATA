using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class Futbol : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
