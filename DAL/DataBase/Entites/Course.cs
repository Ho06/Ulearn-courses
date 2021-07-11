using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ULearn.DAL.DataBase.Entites;

namespace ULearn.DataBase.Entites
{
    public class Course
    {
        public Course()
        {
            CrsCarts = new HashSet<CrsCart>();
            LearnCrs = new HashSet<LearnCr>();
            StdCrs = new HashSet<StdCr>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Duration { get; set; }
        [Required]
        public string Descripton { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? InsId { get; set; }
        public int? LoneId { get; set; }
        public int? LtwoId { get; set; }
        public int? LthreeId { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


        public Category Category { get; set; }
        public virtual Instructor Ins { get; set; }
        public virtual Levelone Lone { get; set; }
        public virtual LevelThree Lthree { get; set; }
        public virtual LevelTwo Ltwo { get; set; }
        public virtual ICollection<CrsCart> CrsCarts { get; set; }
        public virtual ICollection<LearnCr> LearnCrs { get; set; }
        public virtual ICollection<StdCr> StdCrs { get; set; }
        public virtual ICollection<Video> Videos { get; set; }

    }
}
