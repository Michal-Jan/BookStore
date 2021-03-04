using System.ComponentModel.DataAnnotations;

namespace BookStore_API.DTOs
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Password must be between {2} and {1} characters long.", MinimumLength = 8)]
        public string Password { get; set; }
    }
}