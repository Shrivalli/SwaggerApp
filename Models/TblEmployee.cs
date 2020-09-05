using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class TblEmployee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double? Sal { get; set; }
        public DateTime? Doj { get; set; }
        public int? Deptid { get; set; }

        public virtual Tbldepartment Dept { get; set; }
    }
}
