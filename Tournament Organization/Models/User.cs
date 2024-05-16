
using Microsoft.AspNetCore.Identity;

namespace Tournament_Organization.Models
{
    public class User : IdentityUser
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; } = string.Empty;
    }
}
