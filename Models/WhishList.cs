using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class WhishList
    {
        public WhishList()
        {
            CrsWhishes = new HashSet<CrsWhish>();
        }

        public int Id { get; set; }
        public int? StdId { get; set; }

        public virtual Student Std { get; set; }
        public virtual ICollection<CrsWhish> CrsWhishes { get; set; }
    }
}
