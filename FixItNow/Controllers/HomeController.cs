using System.Linq;
using FixItNow.Data;
using Microsoft.AspNetCore.Mvc;

namespace FixItNow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context) { _context = context; }

        public IActionResult Index()
        {
            var topServices = _context.Services.Take(6).ToList();
            return View(topServices);   
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
