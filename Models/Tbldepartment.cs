using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Tbldepartment
    {
        public Tbldepartment()
        {
            TblEmployee = new HashSet<TblEmployee>();
        }

        public int Deptid { get; set; }
        public string Dname { get; set; }
        public string City { get; set; }

        public virtual ICollection<TblEmployee> TblEmployee { get; set; }
    }
}
