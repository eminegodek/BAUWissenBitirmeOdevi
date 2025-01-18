using BilgeHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BilgeHotel.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,PhoneNumber,Email,Address,IdentificationNumber,DateOfBirth")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Index
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }
        // GET: Customer/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,PhoneNumber,Email,Address,IdentificationNumber,DateOfBirth")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Customers.Any(e => e.Id == customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(customer);
        }
        // GET: Customer/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Customers' is null.");
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        // Yeni müşteri eklemek için CreateCustomer sayfasını gösterir
        public IActionResult CreateCustomer()
        {
            return View();
        }

        // Müşteri ekleme işlemi için POST metodu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // Müşteriyi veritabanına ekleme
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");// Başarılı olduktan sonra yönlendirme
            }

            return View(customer); // Eğer hata varsa formu tekrar göster
        }

        // Başarı sayfası (Kayıt başarılı olduktan sonra)
        public IActionResult Success()
        {
            return View();
        }
        // GET: Customer/Profile
        public async Task<IActionResult> Profile()
        {
            // Giriş yapan müşterinin bilgilerini alma
            var customerEmail = User.Identity.Name;
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == customerEmail);

            if (customer == null)
            {
                return RedirectToAction("Index", "Home"); // Eğer müşteri bulunamazsa anasayfaya yönlendirir
            }

            return View(customer); // Müşteri bilgilerini Profile view'ına gönderme
        }
    }
}