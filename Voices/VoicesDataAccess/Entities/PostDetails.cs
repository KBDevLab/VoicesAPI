using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class PostDetails
    {
        [Key]
        public int DetailsId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int? Quantity { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? PostDate { get; set; }

        public virtual PostData Post { get; set; }
        public virtual Users User { get; set; }
    }
}
