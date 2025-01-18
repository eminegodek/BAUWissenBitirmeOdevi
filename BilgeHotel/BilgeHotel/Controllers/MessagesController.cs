using BilgeHotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.Controllers
{
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Mesaj gönderme işlemi
        [HttpPost]
        public IActionResult SaveMessage(ContactMessage model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactMessages.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", model);
        }

        // Tüm mesajları listeleme
        public IActionResult Index()
        {
            var messages = _context.ContactMessages.OrderByDescending(m => m.CreatedAt).ToList();
            return View(messages);
        }

        // Mesaj gönderim sayfası
        public IActionResult Create()
        {
            return View();
        }
    }
}
