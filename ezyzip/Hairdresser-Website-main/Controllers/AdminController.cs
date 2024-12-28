using Hairdresser_Website.Data;
using Hairdresser_Website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hairdresser_Website.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly SalonDbContext _context;

        public AdminController(SalonDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
     
            return View();
        }
    }
}

