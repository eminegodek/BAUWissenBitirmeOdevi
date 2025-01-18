using System.ComponentModel.DataAnnotations;

namespace BilgeHotel.Models
{
    public class RoomViewModel
    {
        [Required]
        public string RoomType { get; set; } // Oda Tipi
        public int Capacity { get; set; } // Kapasite
        public bool HasBalcony { get; set; }
        public bool HasMinibar { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasTV { get; set; }
        public bool HasHairdryer { get; set; }
        public bool HasWiFi { get; set; }
        [Required]
        public decimal PricePerNight { get; set; }
        public int Floor { get; set; }
        public List<Room> Rooms { get; set; }
    }

}
