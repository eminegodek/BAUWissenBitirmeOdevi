namespace BilgeHotel.Models
{
    public class EmployeeSalaryViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal HourlyRate { get; set; }
        public List<ShiftViewModel> Shifts { get; set; }
    }

    public class ShiftViewModel
    {
        public DateTime ShiftDate { get; set; }
        public string ShiftType { get; set; }
        public bool IsOvertime { get; set; }
        public decimal OvertimePay { get; set; }
    }
}
