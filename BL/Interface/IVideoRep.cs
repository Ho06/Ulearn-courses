using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DAL.DataBase.Entites;

namespace ULearn.BL.Interface
{
    public interface IVideoRep
    {
        IEnumerable<Video> Get();
        IEnumerable<Video> Search(string Name);
        IEnumerable<Video> GetVideosById(int stdId, int crsId);
        Video GetById(int id);
        Video GetByEmail(Video model);

        void Insert(Video cat);
        void Update(Video cat);
        void Delete(int id);
    }
}
