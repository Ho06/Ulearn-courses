using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class LevelThree
    {
        public LevelThree()
        {
            Categories = new HashSet<CategoryVM>();
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CategoryVM> Categories { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
