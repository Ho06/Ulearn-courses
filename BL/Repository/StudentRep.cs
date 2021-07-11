using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.DataBase;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Repository
{
    public class StudentRep : IStudentRep
    {
        private readonly Dbcontainner db;

        public StudentRep(Dbcontainner db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> Get()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetByEmail(Student model)
        {
            try
            {
               
                var data = db.Students.Where(a => a.Email == model.Email).FirstOrDefault();
              
                return data;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Insert(Student cat)
        {
            throw new NotImplementedException();
        }
        public int GetWashListId(int stdId)
        {
            var data= db.WhishLists.Where(a => a.StdId == stdId).Select(a => a.Id).FirstOrDefault();
            return data;
        }
        public IEnumerable<Student> Search(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update(Student cat)
        {
            throw new NotImplementedException();
        }
    }
}
