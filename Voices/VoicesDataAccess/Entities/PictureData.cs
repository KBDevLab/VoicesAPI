using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class PictureData
    {
        public PictureData()
        {
            Users = new HashSet<Users>();
        }
        [Key]
        public int PictureId { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgSource { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ImgDate { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
