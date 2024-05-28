
using Microsoft.AspNetCore.Identity;

namespace Tournament_Organization.Models
{
    public class User : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
