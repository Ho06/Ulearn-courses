using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class Student
    {
        public Student()
        {
            Carts = new HashSet<CartVM>();
            LearningLists = new HashSet<LearningList>();
            StdCrs = new HashSet<StdCr>();
            WhishLists = new HashSet<WhishList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<CartVM> Carts { get; set; }
        public virtual ICollection<LearningList> LearningLists { get; set; }
        public virtual ICollection<StdCr> StdCrs { get; set; }
        public virtual ICollection<WhishList> WhishLists { get; set; }
    }
}
