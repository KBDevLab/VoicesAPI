using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VoicesDomain.Models
{
    public class Users
    {
        private string fName;
        private string lName;
        public int UserId { get; set; }
        public string FirstName { get => fName; set {
                if (value.Length == 0 )
                {
                    throw new ArgumentException("First Name Can't Be Empty.", nameof(value));
                }
                fName = value;
            }
        }
        public string LastName { get => lName; set{
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Can't Be Empty.", nameof(value));
                }
                lName = value;
            }
        
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double? Rating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProfileImage> ProfilePicture { get; set; } = new List<ProfileImage>();
        public List<PostData> Post { get; set; } = new List<PostData>();
    }
}
