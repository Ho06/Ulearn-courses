using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class LearnCr
    {
        public int CrsId { get; set; }
        public int LearnId { get; set; }

        public virtual Course Crs { get; set; }
        public virtual LearningList Learn { get; set; }
    }
}
