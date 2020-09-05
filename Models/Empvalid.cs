using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Empvalid
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
    }
}
