using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.DAL.DataBase.Entites;
using ULearn.DataBase;

namespace ULearn.BL.Repository
{
    public class VideoRep : IVideoRep
    {
        private readonly Dbcontainner db;

        public VideoRep( Dbcontainner db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Video> Get()
        {
            throw new NotImplementedException();
        }

        public Video GetByEmail(Video model)
        {
            throw new NotImplementedException();
        }

        public Video GetById(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Video>  GetVideosById(int crsId,int stdId)
        {
            try
            {
                var data = db.Videos.Include(a=>a.Course).Where(a => a.CourseId == crsId).ToList();
                return data ;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Insert(Video cat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Video> Search(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update(Video cat)
        {
            throw new NotImplementedException();
        }
    }
}
