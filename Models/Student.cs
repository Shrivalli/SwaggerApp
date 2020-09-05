using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? TeacherId { get; set; }
        public int? StudentAddressId { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
