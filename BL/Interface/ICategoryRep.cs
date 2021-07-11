using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Interface
{
   public interface ICategoryRep
    {
        IEnumerable<Category> Get();
        IEnumerable<Category> Search(string Name);
        Category GetById(int id);
        void Insert(Category cat);
        void Update(Category cat);
        void Delete(int id);
    }
}
