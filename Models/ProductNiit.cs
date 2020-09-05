using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class ProductNiit
    {
        public int Prid { get; set; }
        public string Prname { get; set; }
        public int? Price { get; set; }
        public int? Qty { get; set; }
        public DateTime? Dop { get; set; }
        public string Category { get; set; }
    }
}
