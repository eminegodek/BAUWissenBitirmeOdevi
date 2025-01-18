// Models/Room.cs
using System.ComponentModel.DataAnnotations;

namespace BilgeHotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public string RoomType { get; set; } // Tek kişilik, Çift kişilik, Kral Dairesi vb.
        [Range(1, 10)]
        public int Capacity { get; set; } // Kapasite
        public bool IsAvailable { get; set; } // Oda müsait mi?
        public int Floor { get; set; } // Kat bilgisi
        public bool HasBalcony { get; set; } // Balkon var mı?
        public bool HasMinibar { get; set; } // Minibar var mı?
        public bool HasAirConditioning { get; set; } // Klima var mı?
        public bool HasTV { get; set; } // TV var mı?
        public bool HasHairdryer { get; set; } // Saç kurutma makinesi var mı?
        public bool HasWiFi { get; set; } // WiFi var mı?
        [Range(1, double.MaxValue)]
        public decimal PricePerNight { get; set; } // Gecelik fiyat
        public string? MaintenanceStatus { get; set; } // "Dolu", "Bakımda", "Müsait"
    }
}
