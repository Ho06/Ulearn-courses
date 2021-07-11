using System;
using System.Collections.Generic;

#nullable disable

namespace ULearn.Models
{
    public partial class CartVM
    {
        public CartVM()
        {
            CrsCarts = new HashSet<CrsCart>();
        }

        public int Id { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? NumOfCourse { get; set; }
        public int? StdId { get; set; }

        public virtual Student Std { get; set; }
        public virtual ICollection<CrsCart> CrsCarts { get; set; }
    }
}
