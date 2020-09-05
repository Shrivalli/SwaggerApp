using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Employeenew
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double? Sal { get; set; }
        public DateTime? Doj { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
    }
}
