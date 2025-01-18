using BilgeHotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Login Sayfası (Hem müşteri, çalışan ve yönetici girişini gösterir)
        public IActionResult Index()
        {
            return View();
        }

        // POST: Login İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Manager'ı kontrol et
                var manager = _context.Managers
                    .FirstOrDefault(m => m.Email == model.Email && m.Password == model.Password);

                if (manager != null)
                {
                    // Manager giriş yaptıysa ManagerPanel'e yönlendirir
                    return RedirectToAction("Index", "Manager");
                }

                // Employee (Resepsiyonist) kontrolü
                var employee = _context.Employees
                    .FirstOrDefault(e => e.Email == model.Email && e.Password == model.Password);

                if (employee != null)
                {
                    if (employee.Position == Position.Receptionist)
                    {
                        // Receptionist giriş yaptıysa ReceptionistPanel'e yönlendir
                        return RedirectToAction("Index", "Receptionist");
                    }
                }

                // Customer kontrolü
                var customer = _context.Customers
                    .FirstOrDefault(c => c.Email == model.Email && c.Password == model.Password);

                if (customer != null)
                {
                    // Customer giriş yaptıysa anasayfaya yönlendir
                    return RedirectToAction("Index", "Home");
                }

                // Kullanıcı bulunamadıysa hata mesajı
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            // Giriş sayfasını tekrar render et
            return View(model);

        }
    }
}
