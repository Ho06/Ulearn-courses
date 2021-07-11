using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class WhishList
    {
        public int Id { get; set; }
        public int StdId { get; set; }
        public virtual Student Std { get; set; }
    }
}
