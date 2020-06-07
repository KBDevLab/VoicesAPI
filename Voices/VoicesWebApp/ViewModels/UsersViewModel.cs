using System.ComponentModel.DataAnnotations;

namespace VoicesWebUI.ViewModels
{
    public class UsersViewModel
    {
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Username { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
