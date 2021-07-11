using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class LearnCr
    {
        public int Id { get; set; }
        public int CrsId { get; set; }
        public int LearnId { get; set; }
        public  Course Crs { get; set; }
        public  LearningList Learn { get; set; }
    }
}
