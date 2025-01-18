using BilgeHotel.Models; // Room modeli için
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.Controllers
{
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Tüm Odaları Listele
        public IActionResult Index()
        {
            var rooms = _context.Rooms.ToList();
            return View(rooms);
        }

        // Oda Durumunu Değiştir
        public IActionResult ToggleAvailability(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound(); // Oda bulunamadı
            }

            // Durumu değiştir
            room.IsAvailable = !room.IsAvailable;

            // Veritabanına kaydet
            _context.SaveChanges();

            TempData["Message"] = $"Oda durumu başarıyla güncellendi: {(room.IsAvailable ? "Müsait" : "Meşgul")}";
            return RedirectToAction("Index");
        }

        // Oda Detaylarını Görüntüle
        public IActionResult Details(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound(); // Oda bulunamadı
            }

            return View(room);
        }

        // Yeni Oda Ekleme Sayfası
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Rooms.Add(room);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(room);
        }

        // Oda Silme
        public IActionResult Delete(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound(); // Oda bulunamadı
            }

            _context.Rooms.Remove(room);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
