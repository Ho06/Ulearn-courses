using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.DataBase.Entites
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
