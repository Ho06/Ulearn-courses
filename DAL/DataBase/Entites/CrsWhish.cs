using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DAL.DataBase.Entites;

namespace ULearn.DataBase.Entites
{
    public class CrsWhish
    {
        public int Id { get; set; }
        public int CrsId { get; set; }
        public int WhishId { get; set; }
        public int VideoLink { get; set; }
        public WhishList Whish { get; set; }
    }
}
