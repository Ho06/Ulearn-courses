using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.DataBase;
using ULearn.DataBase.Entites;
using Microsoft.EntityFrameworkCore;
namespace ULearn.BL.Repository
{
    public class CategoryRep : ICategoryRep
    {
        private readonly Dbcontainner db;

        public CategoryRep(Dbcontainner db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Get()
        {
            try
            {
              var data=db.Categories.Select(a => a);

                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Category GetById(int id)
        {
            try
            {
               var data=  db.Categories.Include(a=>a.Courses).Include(a=>a.Lone).Include(a=>a.Ltwo).Include(a=>a.Lthree).Where(a => a.Id == id).SingleOrDefault();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            throw new NotImplementedException();
        }

        public void Insert(Category cat)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Search(string Name)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            throw new NotImplementedException();
        }

        public void Update(Category cat)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            throw new NotImplementedException();
        }
    }
}
