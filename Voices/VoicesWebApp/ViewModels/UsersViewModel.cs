using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace VoicesWebUI.ViewModels
{
    public class UsersViewModel
    {
        public int UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
