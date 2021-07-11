using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.DataBase;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Repository
{
  
    public class LearnCrsRep : ILearnCrsRep
    {
        private readonly Dbcontainner db;

        public LearnCrsRep(Dbcontainner db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(LearnCr cat)
        {
            try
            {
                db.LearnCrs.Add(cat);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(LearnCr cat)
        {
            throw new NotImplementedException();
        }
    }
}
