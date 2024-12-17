using Hairdresser.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hairdresser.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult CorrectLogin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Admin(AdminLogin login)
        {
            if (login.Username == "B211210575@gamil.com" && login.Password == "1234") 
            {
                return RedirectToAction("CorrectLogin");
            }
            return RedirectToAction("Admin");
        }


        [HttpGet]
        public IActionResult User()
        {
            return View();
        }

        [HttpPost]
        public IActionResult User(UserLogin login)
        {
            return View(login);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


    }
}
