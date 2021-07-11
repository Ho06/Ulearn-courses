using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;

namespace ULearn.BL.Interface
{
  public  interface IStudentRep
    {
        IEnumerable<Student> Get();
        IEnumerable<Student> Search(string Name);
        Student GetById(int id);
        Student GetByEmail(Student model);
        int GetWashListId(int stdId);
        void Insert(Student cat);
        void Update(Student cat);
        void Delete(int id);
    }
}
