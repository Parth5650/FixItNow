using System.Linq;
using System.Threading.Tasks;
using FixItNow.Data;
using FixItNow.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FixItNow.Controllers
{
    public class RequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RequestsController(ApplicationDbContext context) { _context = context; }

        // GET: Requests/Create
        [Authorize]
        public IActionResult Create(int? serviceId)
        {
            var services = _context.Services.Include(s => s.Category)
                .Select(s => new { s.Id, Name = s.Name + " (" + s.Category.Name + ")" }).ToList();

            ViewData["ServiceId"] = new SelectList(services, "Id", "Name", serviceId);
            var model = new ServiceRequest();
            if (serviceId.HasValue) model.ServiceId = serviceId.Value;
            return View(model);
        }

        // POST: Requests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("CustomerName,Phone,Address,ServiceId,PreferredDate,Notes")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                var service = await _context.Services.FindAsync(serviceRequest.ServiceId);
                if (service != null) serviceRequest.EstimatedPrice = service.Price;

                _context.Add(serviceRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            var services = _context.Services.Include(s => s.Category)
                .Select(s => new { s.Id, Name = s.Name + " (" + s.Category.Name + ")" }).ToList();
            ViewData["ServiceId"] = new SelectList(services, "Id", "Name", serviceRequest.ServiceId);
            return View(serviceRequest);
        }
    }
}
