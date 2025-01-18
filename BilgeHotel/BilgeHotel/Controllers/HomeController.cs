using BilgeHotel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BilgeHotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Manager olarak kontrol
            var manager = _context.Managers.FirstOrDefault(m => m.Email == email && m.Password == password);
            if (manager != null)
            {
                HttpContext.Session.SetString("UserName", manager.Name);
                HttpContext.Session.SetString("UserRole", "Manager");
                return RedirectToAction("Index", "Manager");
            }

            // Receptionist olarak kontrol
            var receptionist = _context.Employees.FirstOrDefault(e => e.Email == email && e.Password == password && e.Position == Position.Receptionist);
            if (receptionist != null)
            {
                HttpContext.Session.SetString("UserName", receptionist.Name);
                HttpContext.Session.SetString("UserRole", "Receptionist");
                return RedirectToAction("Index", "Receptionist");
            }

            TempData["Error"] = "Geçersiz e-posta veya þifre.";
            return RedirectToAction("Login");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
