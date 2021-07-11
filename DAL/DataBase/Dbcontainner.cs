using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DAL.DataBase.Entites;
using ULearn.DataBase.Entites;
namespace ULearn.DataBase
{
    public class Dbcontainner :IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public Dbcontainner(DbContextOptions<Dbcontainner> opt) : base(opt)
        {
    
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsCart> CrsCarts { get; set; }
        public DbSet<CrsWhish> CrsWhishes { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<LearnCr> LearnCrs { get; set; }
        public DbSet<LearningList> LearningLists { get; set; }
        public DbSet<LevelThree> LevelThrees { get; set; }
        public DbSet<LevelTwo> LevelTwos { get; set; }
        public DbSet<Levelone> Levelones { get; set; }
        public DbSet<StdCr> StdCrs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<WhishList> WhishLists { get; set; }
        public DbSet<Video> Videos { get; set; }

    }
}
