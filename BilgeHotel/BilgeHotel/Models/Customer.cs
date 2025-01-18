using System.ComponentModel.DataAnnotations;

namespace BilgeHotel.Models
{
    // Models/Customer.cs
    public class Customer
    {
        public int Id { get; set; } // Müşterinin benzersiz ID'si

        [Required(ErrorMessage = "Ad ve soyad gereklidir.")]
        [StringLength(100, ErrorMessage = "Ad ve soyad en fazla 100 karakter olabilir.")]
        public string FullName { get; set; } // Müşteri adı ve soyadı

        [Required(ErrorMessage = "Telefon numarası gereklidir.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası girin.")]
        public string PhoneNumber { get; set; } // Telefon numarası

        [Required(ErrorMessage = "E-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        public string Email { get; set; } // E-posta adresi

        [Required(ErrorMessage = "Adres gereklidir.")]
        [StringLength(200, ErrorMessage = "Adres en fazla 200 karakter olabilir.")]
        public string Address { get; set; } // Adres

        [Required(ErrorMessage = "Kimlik numarası gereklidir.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Kimlik numarası 11 haneli olmalıdır.")]
        public string IdentificationNumber { get; set; } // T.C. kimlik numarası

        [Required(ErrorMessage = "Doğum tarihi gereklidir.")]
        public DateTime DateOfBirth { get; set; } // Doğum tarihi
        public string Password { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
