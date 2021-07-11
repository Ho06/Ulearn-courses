using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Interface
{
 public   interface ICourseRep
    {
        IEnumerable<Course> Get();
        IEnumerable<Course> Search(string Name);
        Course GetById(int id);
        IEnumerable<string> GetNameById(int id);
        IEnumerable<decimal> GetPriceById(int id);
        IEnumerable<decimal> GetDurationById(int id);

        void Insert(Course cat);
        void Update(Course cat);
        void Delete(int id);
    }
}
