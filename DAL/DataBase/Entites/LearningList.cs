using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class LearningList
    {
        public int Id { get; set; }
        public int StdId { get; set; }
        public  Student Std { get; set; }
      
        public virtual ICollection<LearnCr> LearnCrs { get; set; }
       
    }
}
