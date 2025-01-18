namespace BilgeHotel.Models
{
    // Models/Payment.cs
    public class Payment
    {
        public int Id { get; set; } // Ödeme ID'si
        public int ReservationId { get; set; } // İlgili rezervasyon ID'si
        public Reservation Reservation { get; set; } // İlişkili Rezervasyon (Navigation Property)
        public decimal Amount { get; set; } // Ödeme miktarı
        public DateTime PaymentDate { get; set; } // Ödeme tarihi
        public string PaymentMethod { get; set; } // Ödeme metodu (Kredi Kartı, Nakit vb.)
    }

}
