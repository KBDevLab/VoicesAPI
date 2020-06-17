using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PostData
    {
        public PostData()
        {
            PostDetails = new HashSet<PostDetails>();
            Users = new HashSet<Users>();
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public byte[] Media { get; set; }
        public string Comment { get; set; }
        public double? Rating { get; set; }

        public virtual ICollection<PostDetails> PostDetails { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
