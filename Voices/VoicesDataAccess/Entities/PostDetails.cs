using System;
using System.Collections.Generic;

namespace VoicesWebUI.Entities
{
    public partial class PostDetails
    {
        public int DetailsId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? PostDate { get; set; }

        public virtual PostData Post { get; set; }
        public virtual Users User { get; set; }
    }
}
