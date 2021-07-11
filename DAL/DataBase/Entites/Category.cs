using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int LoneId { get; set; }
        public int LtwoId { get; set; }
        public int LthreeId { get; set; }
        public int CourseId { get; set; }
        public IEnumerable<Course>  Courses { get; set; }
        public  Levelone Lone { get; set; }
        public  LevelThree Lthree { get; set; }
        public  LevelTwo Ltwo { get; set; }
    }
}
