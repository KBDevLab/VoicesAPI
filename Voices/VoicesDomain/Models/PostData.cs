using System;
using System.Collections.Generic;
using System.Text;

namespace VoicesDomain.Models
{
    public class PostData
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public byte[] Media { get; set; }
        public string Comment { get; set; }
        public double? Rating { get; set; }
    }
}
