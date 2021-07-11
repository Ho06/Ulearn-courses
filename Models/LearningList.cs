using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class LearningList
    {
        public LearningList()
        {
            LearnCrs = new HashSet<LearnCr>();
        }

        public int Id { get; set; }
        public int? StdId { get; set; }

        public virtual Student Std { get; set; }
        public virtual ICollection<LearnCr> LearnCrs { get; set; }
    }
}
