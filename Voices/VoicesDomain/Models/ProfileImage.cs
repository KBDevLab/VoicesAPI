using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ProfileImage
    {
        public int PictureId { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgSource { get; set; }
        public DateTime? ImgDate { get; set; }
    }
}
