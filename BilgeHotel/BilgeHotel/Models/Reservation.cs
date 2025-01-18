namespace BilgeHotel.Models
{
    // Models/Reservation.cs
    public class Reservation
    {
        public int Id { get; set; } // Rezervasyonun benzersiz ID'si
        public int RoomId { get; set; } // Rezervasyon yapılan odanın ID'si
        public Room Room { get; set; } // İlişkili Oda (Navigation Property)
        public int CustomerId { get; set; } // Müşteri ID'si
        public Customer Customer { get; set; } // İlişkili Müşteri (Navigation Property)
        public DateTime StartDate { get; set; } // Başlangıç tarihi
        public DateTime EndDate { get; set; } // Bitiş tarihi
        public decimal Price { get; set; } // Toplam fiyat
        public string Status { get; set; } // Rezervasyon durumu (Aktif, İptal Edildi vb.)

    }

}
