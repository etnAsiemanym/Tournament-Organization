using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tournament_Organization.Models;
using Microsoft.EntityFrameworkCore;

namespace Tournament_Organization.Controllers
{
    public class HomeController : Controller
    {   

        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
