using Microsoft.AspNetCore.Mvc;
using Tournament_Organization.Models;

namespace Tournament_Organization.Controllers
{
    public class TournamentController : Controller
    {
        private readonly ApplicationContext _context;

        public TournamentController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
