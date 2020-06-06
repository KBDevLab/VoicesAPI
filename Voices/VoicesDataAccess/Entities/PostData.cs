using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class PostData
    {
        public PostData()
        {
            PostDetails = new HashSet<PostDetails>();
            Users = new HashSet<Users>();
        }

        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Upload)]
        public byte[] Media { get; set; }
        public string Comment { get; set; }
        public double? Rating { get; set; }

        public virtual ICollection<PostDetails> PostDetails { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
