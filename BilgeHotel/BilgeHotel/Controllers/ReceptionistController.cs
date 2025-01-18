using Microsoft.AspNetCore.Mvc;
namespace BilgeHotel.Controllers
{
    public class ReceptionistController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReceptionistController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
