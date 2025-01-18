using Microsoft.AspNetCore.Identity;

namespace BilgeHotel.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}
