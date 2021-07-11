using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class StdCr
    {
        public int StdId { get; set; }
        public int CrsId { get; set; }

        public virtual Course Crs { get; set; }
        public virtual Student Std { get; set; }
    }
}
