using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace VoicesWebUI.ViewModels
{
    public class UsersViewModel
    {
        public int UserId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 chars")]
        [MaxLength(30, ErrorMessage = "Too many chars")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 chars")]
        [MaxLength(30, ErrorMessage = "Too many chars")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Username can't be empty")]
        [MaxLength(20, ErrorMessage = "Username too long")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password must be longer than 5 chars")]
        [MaxLength(20, ErrorMessage = "Password too long, Must be shorter than 20 chars")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
