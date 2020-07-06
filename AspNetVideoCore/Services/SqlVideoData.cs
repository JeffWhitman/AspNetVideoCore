using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Data;
using AspNetVideoCore.Entities;

namespace AspNetVideoCore.Services
{
    public class SqlVideoData : IVideoData
    {
        private ApplicationContext db;

        public SqlVideoData(ApplicationContext db)
        {
            this.db = db;
        }

        public void Add(Video newVideo)
        {
            db.Add(newVideo);
            db.SaveChanges();
        }

        public Video Get(int id)
        {
            return db.Find<Video>(id);
        }
        public IEnumerable<Video> GetAll()
        {
            return db.Videos;
        }
    }
}
