using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Interface
{
   public interface ILearnCrsRep

    {
        void Insert(LearnCr cat);
        void Update(LearnCr cat);
        void Delete(int id);
    }
}
