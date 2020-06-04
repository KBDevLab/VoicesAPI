using System;
using System.Collections.Generic;

namespace VoicesWebUI.Entities
{
    public partial class PictureData
    {
        public int PictureId { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgSource { get; set; }
        public DateTime? ImgDate { get; set; }
    }
}
