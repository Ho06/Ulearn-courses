using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class CrsCart
    {
        public int CrsId { get; set; }
        public int CartId { get; set; }

        public virtual CartVM Cart { get; set; }
        public virtual Course Crs { get; set; }
    }
}
