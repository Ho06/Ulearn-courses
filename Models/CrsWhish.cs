using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class CrsWhish
    {
        public int CrsId { get; set; }
        public int WhishId { get; set; }

        public virtual WhishList Whish { get; set; }
    }
}
