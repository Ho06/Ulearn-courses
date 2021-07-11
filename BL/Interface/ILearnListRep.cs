using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Interface
{
   public interface ILearnListRep
    {
        IEnumerable<LearningList> Get();
        IEnumerable<LearningList> Search(string Name);
        IEnumerable<LearningList> GetById(int id);
        void Insert(LearningList cat);
        void Update(LearningList cat);
        void Delete(int id);
       IEnumerable<int> GetLearnListId(int StdId);
        Task< IEnumerable<int>> GetLearnListIdAsync(int StdId);
    }
}
