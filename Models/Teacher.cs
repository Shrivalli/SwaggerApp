using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Student = new HashSet<Student>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
