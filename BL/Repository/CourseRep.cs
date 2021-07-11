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
    public class CourseRep : ICourseRep
    {
        private readonly Dbcontainner db;

        public CourseRep(Dbcontainner db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> Get()
        {
            try
            {
                var data = db.Courses.Select(a => a);

                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Course GetById(int id)
        {
            try
            {
                var data = db.Courses.Include(a => a.Ins).Include(a => a.Category).Include(a => a.Lone).Include(a => a.Ltwo).Include(a => a.Lthree).Where(a => a.Id == id).SingleOrDefault();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<decimal> GetDurationById(int id)
        {
            try
            {
                var duraion = db.Courses.Where(a => a.Id == id).Select(a => a.Duration);
                return duraion ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<string> GetNameById(int id)
        {
            try
            {
                var subject = db.Courses.Where(a => a.Id == id).Select(a => a.Name);
                return subject;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<decimal> GetPriceById(int id)
        {
            try
            {
                var price = db.Courses.Where(a => a.Id == id).Select(a => a.Price);
                return price;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Insert(Course cat)
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

        public IEnumerable<Course> Search(string Name)
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

        public void Update(Course cat)
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
