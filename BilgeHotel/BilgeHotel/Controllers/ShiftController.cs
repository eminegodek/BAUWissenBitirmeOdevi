using BilgeHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BilgeHotel.Controllers
{
    public class ShiftController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShiftController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Çalışan maaşları ve vardiya bilgileri
        public async Task<IActionResult> SalaryList()
        {
            var employees = await _context.Employees.Include(e => e.Shifts).ToListAsync();

            // employeeSalaries listesine verileri atama
            var employeeSalaries = employees.Select(e => new EmployeeSalaryViewModel
            {
                EmployeeId = e.Id,
                EmployeeName = e.Name,
                Position = e.Position.ToString(),
                MonthlySalary = e.MonthlySalary,
                HourlyRate = e.HourlyRate,
                Shifts = e.Shifts.Select(s => new ShiftViewModel
                {
                    ShiftDate = s.ShiftDate,
                    ShiftType = s.ShiftType.ToString(),
                    IsOvertime = s.IsOvertime,
                    OvertimePay = s.IsOvertime ? (s.ShiftEnd - s.ShiftStart).Hours * e.HourlyRate * 1.5m : 0m
                }).ToList()
            }).ToList();

            // Eğer liste boşsa "No data found" döndür
            if (!employeeSalaries.Any())
            {
                return Content("No data found.");
            }

            // Eğer veriler varsa, view'a gönder
            return View(employeeSalaries);
        }


        // Mesai hesaplama fonksiyonu
        private decimal CalculateOvertime(Employee employee, Shift shift)
        {
            var overtimeRate = 1.5m; // Mesai oranı
            decimal overtimePay = 0;

            if (shift.IsOvertime && shift.ShiftEnd.Hour >= 18) // Mesai saatinin başladığı saat
            {
                overtimePay = (shift.ShiftEnd - shift.ShiftStart).Hours * employee.HourlyRate * overtimeRate;
            }

            return overtimePay;
        }
    }
}
