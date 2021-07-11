using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Interface
{
  public  interface IWashListRep
    {
        IEnumerable<CrsWhish> Get();
        IEnumerable<CrsWhish> Search(string Name);
        IEnumerable<CrsWhish> GetVideosById(int stdId, int crsId);
        Task<IEnumerable<int>> GetCrsByWtshListId(int WashId);
        int GetWashedByWashId(int? washId, int crsId);
       IEnumerable<CrsWhish> GetVideoLinkByWashId(int id, int washId);
        CrsWhish GetById(int id);
        CrsWhish GetByEmail(CrsWhish model);
        void Insert(CrsWhish cat);
        void Update(CrsWhish cat);
        void Delete(int id);
    }
}
