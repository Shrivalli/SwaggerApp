using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class StudentAddress
    {
        public StudentAddress()
        {
            Student = new HashSet<Student>();
        }

        public int StudentAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
