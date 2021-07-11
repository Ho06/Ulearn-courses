using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.DAL.DataBase.Entites
{
    public class Video
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string VidLink { get; set; }


        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
