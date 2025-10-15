using System;
using System.Linq;
using System.Threading.Tasks;
using FixItNow.Data;
using FixItNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FixItNow.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ServicesController(ApplicationDbContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.Include(s => s.Category).ToListAsync();
            return View(services);
        }

        public async Task<IActionResult> Details(int id)
        {
            var service = await _context.Services.Include(s => s.Category).FirstOrDefaultAsync(s => s.Id == id);
            if (service == null) return NotFound();
            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Book(int serviceId, DateTime preferredDate, string preferredTime, string address, string notes)
        {
            // Extra validation for required fields
            if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(preferredTime) || preferredDate < DateTime.Today.AddDays(1))
            {
                TempData["Error"] = "Please fill in all required fields and select a valid date.";
                return RedirectToAction("Details", new { id = serviceId });
            }

            var service = await _context.Services.FindAsync(serviceId);
            if (service == null)
            {
                return NotFound();
            }

            // Get current user ID if logged in
            var userIdClaim = User.FindFirst(ClaimTypes.Name);
            int? userId = null;
            if (userIdClaim != null)
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == userIdClaim.Value);
                userId = user?.Id;
            }

            var serviceRequest = new ServiceRequest
            {
                ServiceId = serviceId,
                PreferredDate = preferredDate,
                PreferredTime = preferredTime,
                Address = address,
                Notes = notes,
                EstimatedPrice = service.Price + 50, // Service price + platform fee
                Status = "Pending",
                UserId = userId,
                CustomerName = userId.HasValue ?
                    (await _context.Users.FindAsync(userId))?.Username ?? "Guest" :
                    "Guest",
                Phone = userId.HasValue ?
                    (await _context.Users.FindAsync(userId))?.PhoneNumber ?? "" :
                    ""
            };

            _context.ServiceRequests.Add(serviceRequest);
            await _context.SaveChangesAsync();

            return RedirectToAction("BookingSuccess", new { id = serviceRequest.Id });
        }

        public async Task<IActionResult> BookingSuccess(int id)
        {
            var booking = await _context.ServiceRequests
                .Include(sr => sr.Service)
                .Include(sr => sr.User)
                .FirstOrDefaultAsync(sr => sr.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }
    }
}
