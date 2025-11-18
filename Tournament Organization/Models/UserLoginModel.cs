using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tournament_Organization.Models
{
    public class UserLoginModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [DisplayName("Remember me?")]
        public bool RememberMe { get; set; }
    }
}
