using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Images
    {
        public string RollNo { get; set; }
        public byte[] Img { get; set; }
        public DateTime? ImgDate { get; set; }
    }
}
