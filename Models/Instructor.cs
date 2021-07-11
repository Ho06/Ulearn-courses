using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        public int InsId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
