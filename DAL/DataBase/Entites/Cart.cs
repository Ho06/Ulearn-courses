using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public int NumOfCourse { get; set; }
        public int StdId { get; set; }
    }
}
