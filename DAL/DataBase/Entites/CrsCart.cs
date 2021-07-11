using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.DataBase.Entites
{
    public class CrsCart
    {
        public int Id { get; set; }
        public int CrsId { get; set; }
        public int CartId { get; set; }
        public  Cart Cart { get; set; }
        public  Course Crs { get; set; }
    }
}
