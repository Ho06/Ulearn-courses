using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.DataBase;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Repository
{
    public class WashListRep : IWashListRep
    {
        private readonly Dbcontainner db;

        public WashListRep(Dbcontainner db)
        {
            this.db = db;
        }


        public async Task< IEnumerable<int>> GetCrsByWtshListId(int WashId)
        {
            var data = await db.CrsWhishes.Where(a => a.WhishId == WashId).Select(a => a.CrsId).ToListAsync();
            return data;
        }
       
        public IEnumerable<CrsWhish> GetVideoLinkByWashId(int id, int washId)
        {
            var data =  db.CrsWhishes.Where(a => a.WhishId==washId).Select(a => a).ToList();
            return data;

        }

        public int GetWashedByWashId(int? washId ,int crsId)
        {
            try
            {
                var data = db.CrsWhishes.Where(a => a.WhishId == washId).SingleOrDefault(a => a.CrsId == crsId);
              
                    if (data==null)
                    {
                        return 1;
                    }
                  
                

                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CrsWhish> Get()
        {
            throw new NotImplementedException();
        }

        public CrsWhish GetByEmail(CrsWhish model)
        {
            throw new NotImplementedException();
        }

        public CrsWhish GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CrsWhish> GetVideosById(int stdId, int crsId)
        {
            throw new NotImplementedException();
        }

        public void  Insert(CrsWhish cat)
        {
            if ( GetWashedByWashId(cat.WhishId,cat.CrsId)==1)
            {
                try
                {
                    var data =  db.CrsWhishes.Add(cat);
                     db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            
             }
            
        }

       

        public IEnumerable<CrsWhish> Search(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update(CrsWhish cat)
        {
            throw new NotImplementedException();
        }
    }
}
