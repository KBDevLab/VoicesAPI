using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class Users
    {
        public Users()
        {
            PostDetails = new HashSet<PostDetails>();
        }
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int? ProfilePic { get; set; }
        public int? Posts { get; set; }

        public virtual PostData PostsNavigation { get; set; }
        public virtual PictureData ProfilePicNavigation { get; set; }
        public virtual ICollection<PostDetails> PostDetails { get; set; }
    }
}
