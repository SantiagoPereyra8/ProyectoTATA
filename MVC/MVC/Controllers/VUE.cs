using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class VUE : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
