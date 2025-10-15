using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FixItNow.Data;
using FixItNow.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace FixItNow.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context) { _context = context; }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string username, string password, string returnUrl = null)
        {
            // Admin shortcut
            if (username == "admin" && password == "0000")
            {
                var adminUser = _context.Users.FirstOrDefault(u => u.Username == "admin");
                if (adminUser == null)
                {
                    adminUser = new User { Username = "admin", PasswordHash = "0000", IsAdmin = true };
                    _context.Users.Add(adminUser);
                    await _context.SaveChangesAsync();
                }
                await SignInAsync(adminUser);
                return RedirectAfterLogin(returnUrl);
            }

            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }

            await SignInAsync(user);
            return RedirectAfterLogin(returnUrl);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(string username, string email, string phoneNumber, string password, string zipCode)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || 
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || 
                string.IsNullOrWhiteSpace(zipCode))
            {
                ModelState.AddModelError("", "Please fill in all required fields.");
                TempData["ErrorMessage"] = "Please fill in all required fields.";
                return View();
            }

            if (_context.Users.Any(u => u.Username == username))
            {
                ModelState.AddModelError("", "Username already exists");
                TempData["ErrorMessage"] = "Username already exists.";
                return View();
            }

            if (_context.Users.Any(u => u.Email == email))
            {
                ModelState.AddModelError("", "Email already exists");
                TempData["ErrorMessage"] = "Email already exists.";
                return View();
            }

            try
            {
                var newUser = new User 
                { 
                    Username = username, 
                    Email = email,
                    PhoneNumber = phoneNumber,
                    ZipCode = zipCode,
                    PasswordHash = password, 
                    IsAdmin = false 
                };
                
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();

                // Confirm persistence
                var savedUser = _context.Users.FirstOrDefault(u => u.Username == username);
                if (savedUser == null)
                {
                    ModelState.AddModelError("", "Registration failed. Please try again.");
                    TempData["ErrorMessage"] = "Registration failed. Please try again.";
                    return View();
                }

                TempData["SuccessMessage"] = "Your account has been created successfully.";
                await SignInAsync(savedUser);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                TempData["ErrorMessage"] = "Registration error: " + ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> MyBookings()
        {
            var username = User?.Identity?.Name;
            if (string.IsNullOrEmpty(username)) return RedirectToAction("Login");

            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return RedirectToAction("Login");

            var bookings = await _context.ServiceRequests
                .Include(sr => sr.Service)
                .ThenInclude(s => s.Category)
                .Where(sr => sr.UserId == user.Id)
                .OrderByDescending(sr => sr.Id)
                .ToListAsync();

            return View(bookings);
        }

        private async Task SignInAsync(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("IsAdmin", user.IsAdmin ? "true" : "false")
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

        private IActionResult RedirectAfterLogin(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            return RedirectToAction("Index", "Home");
        }
    }
}

