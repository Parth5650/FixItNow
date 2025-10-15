using System.Threading.Tasks;
using FixItNow.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FixItNow.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            var requests = await _context.ServiceRequests
                .Include(r => r.Service)
                .ThenInclude(s => s.Category)
                .ToListAsync();
            return View(requests);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatus(int id, string status)
        {
            var req = await _context.ServiceRequests.FindAsync(id);
            if (req == null) return NotFound();
            req.Status = status;
            _context.Update(req);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
