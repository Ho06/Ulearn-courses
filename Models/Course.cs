using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class Course
    {
        public Course()
        {
            CrsCarts = new HashSet<CrsCart>();
            LearnCrs = new HashSet<LearnCr>();
            StdCrs = new HashSet<StdCr>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Duration { get; set; }
        public string Descripton { get; set; }
        public decimal? Price { get; set; }
        public int? InsId { get; set; }
        public int? LoneId { get; set; }
        public int? LtwoId { get; set; }
        public int? LthreeId { get; set; }

        public virtual Instructor Ins { get; set; }
        public virtual Levelone Lone { get; set; }
        public virtual LevelThree Lthree { get; set; }
        public virtual LevelTwo Ltwo { get; set; }
        public virtual ICollection<CrsCart> CrsCarts { get; set; }
        public virtual ICollection<LearnCr> LearnCrs { get; set; }
        public virtual ICollection<StdCr> StdCrs { get; set; }
    }
}
