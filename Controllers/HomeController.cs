using System.Diagnostics;
using Hairdresser.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hairdresser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Appointment()
        {
            return View();
        }
        public IActionResult AIHair()
        {
            return View();
        }
    }
}
