﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class StdCr
    {
        public int Id { get; set; }
        public int StdId { get; set; }
        public int CrsId { get; set; }
        public  Course Crs { get; set; }
        public  Student Std { get; set; }
    }
}
