using Microsoft.AspNetCore.Identity;

namespace EventManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; }  // Optional: helpful for displaying role
    }
}
