using BilgeHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BilgeHotel.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Reservation/Index
        public async Task<IActionResult> Index()
        {
            // Rezervasyonları Oda ve Müşteri bilgileriyle birlikte alır
            var reservations = await _context.Reservations
                .Include(r => r.Room)
                .Include(r => r.Customer)
                .ToListAsync();

            return View(reservations);
        }
        // Odaları Listeleme ve Rezervasyon Formu
        public IActionResult Create()
        {
            var rooms = _context.Rooms
                .Where(r => r.IsAvailable)
                .GroupBy(r => new { r.RoomType, r.Floor }) // Oda tipi ve kat bilgisine göre gruplama
                .Select(g => new RoomViewModel
                {
                    RoomType = g.Key.RoomType,
                    Floor = g.Key.Floor,
                    Rooms = g.ToList()
                }).ToList();

            return View(rooms);
        }

        [HttpPost]
        public IActionResult Create(int roomId, string identificationNumber, DateTime startDate, DateTime endDate)
        {
            // Oda kontrolü
            var room = _context.Rooms.FirstOrDefault(r => r.Id == roomId && r.IsAvailable);
            if (room == null)
            {
                ModelState.AddModelError("", "Seçilen oda mevcut değil!");
                return View();
            }

            // Tarih aralığını kontrol et
            int totalDays = (endDate - startDate).Days;
            if (totalDays <= 0)
            {
                ModelState.AddModelError("", "Geçerli bir tarih aralığı seçiniz!");
            }

            // Kullanıcıyı kontrol et
            var customer = _context.Customers.FirstOrDefault(c => c.IdentificationNumber == identificationNumber);
            if (customer == null)
            {
                ModelState.AddModelError("", "Lütfen kayıt olunuz!");
            }

            // Eğer model hataları varsa sayfayı aynı model ile döndür
            if (!ModelState.IsValid)
            {
                var rooms = _context.Rooms
                    .Where(r => r.IsAvailable)
                    .GroupBy(r => new { r.RoomType, r.Floor })
                    .Select(g => new RoomViewModel
                    {
                        RoomType = g.Key.RoomType,
                        Floor = g.Key.Floor,
                        Rooms = g.ToList()
                    }).ToList();

                return View(rooms);
            }

            // Fiyat hesaplama ve indirim uygulama
            decimal totalPrice = totalDays * room.PricePerNight;
            if ((startDate - DateTime.Today).Days >= 30)
            {
                totalPrice *= 0.77m; // %23 indirim
            }

            // Rezervasyon oluştur ve kaydet
            var reservation = new Reservation
            {
                RoomId = roomId,
                CustomerId = customer.Id,
                StartDate = startDate,
                EndDate = endDate,
                Price = totalPrice,
                Status = "Active"
            };

            room.IsAvailable = false; // Odayı rezerve et
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return RedirectToAction("Confirmation", new { price = totalPrice });
        }

        // Rezervasyon Onayı
        public IActionResult Confirmation(decimal price)
        {
            ViewBag.Price = price;
            return View();
        }

    }
}
