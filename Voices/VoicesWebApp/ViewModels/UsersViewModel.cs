using DataAccess.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

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
