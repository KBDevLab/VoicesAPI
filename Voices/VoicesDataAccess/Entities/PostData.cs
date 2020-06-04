using System;
using System.Collections.Generic;

namespace VoicesWebUI.Entities
{
    public partial class PostData
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public byte[] Media { get; set; }
        public string Comment { get; set; }
        public double? Rating { get; set; }
    }
}
