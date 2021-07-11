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
    public class LearnListRep : ILearnListRep
    {
        private readonly Dbcontainner db;

        public LearnListRep(Dbcontainner db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LearningList> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LearningList> GetById(int id)
        {
            try
            {
                var data = db.LearningLists.Include(a => a.Std).Include(a=>a.LearnCrs).Where(a => a.StdId == id).Select(a=>a);
                
                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<int> GetLearnListId(int StdId)
        {
            try
            {
              return   db.LearningLists.Where(a => a.StdId == StdId).Select(a => a.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<int>> GetLearnListIdAsync(int StdId)
        {
            try
            {
                return await db.LearningLists.Where(a => a.StdId == StdId).Select(a => a.Id).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Insert(LearningList cat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LearningList> Search(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update(LearningList cat)
        {
            throw new NotImplementedException();
        }
    }
}
