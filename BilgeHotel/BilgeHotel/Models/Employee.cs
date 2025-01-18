namespace BilgeHotel.Models
{
    public enum Position
    {
        Receptionist = 1,
        Cleaner = 2,
        Chef = 3,
        Waiter = 4,
        Electrician = 5,
        IT_Specialist = 6
    }


    public class Employee
    {
        public int Id { get; set; } // Çalışanın benzersiz ID'si
        public string Name { get; set; } // Çalışan adı
        public Position Position { get; set; } // Çalışanın pozisyonu (enum kullanıldı)
        public string PhoneNumber { get; set; } // Telefon numarası
        public string Email { get; set; } // E-posta adresi
        public string Password { get; set; }
        public decimal HourlyRate { get; set; } // Saatlik ücret
        public decimal MonthlySalary { get; set; } // Aylık maaş
        public DateTime ShiftStart { get; set; } // Vardiya başlangıç saati
        public DateTime ShiftEnd { get; set; } // Vardiya bitiş saati
        public ICollection<Shift> Shifts { get; set; } // Bir çalışanın birden fazla vardiyası olabilir

        public void ApplyOvertime(decimal overtimePay)
        {
            MonthlySalary += overtimePay; // Mesai ücretini maaşa ekleyebilirsin
        }
    }

    public class Manager
    {
        public int Id { get; set; } // Yöneticinin benzersiz ID'si
        public string Name { get; set; } // Yönetici adı
        public string Title { get; set; } // Yönetici unvanı
        public string PhoneNumber { get; set; } // Telefon numarası
        public string Email { get; set; } // E-posta adresi
        public string Password { get; set; }
        public decimal MonthlySalary { get; set; } // Aylık maaş
    }
}
