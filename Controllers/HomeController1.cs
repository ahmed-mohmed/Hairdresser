using Microsoft.AspNetCore.Mvc;

namespace Hairdresser.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
