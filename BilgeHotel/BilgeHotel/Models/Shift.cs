namespace BilgeHotel.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } // Çalışan ile ilişki
        public DateTime ShiftDate { get; set; } // Vardiya tarihi
        public ShiftType ShiftType { get; set; } // Vardiya türü (enum)
        public bool IsHoliday { get; set; } // İzinli mi?
        public bool IsOvertime { get; set; } // Fazla mesai mi?
        public DateTime ShiftStart { get; set; } // Vardiya başlangıç saati
        public DateTime ShiftEnd { get; set; } // Vardiya bitiş saati
    }


    public enum ShiftType
    {
        Morning = 6,
        Afternoon = 7,
        Night = 8,
        Overtime = 9
    }
}
