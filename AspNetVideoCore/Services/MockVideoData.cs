using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Entities;

namespace AspNetVideoCore.Services
{
    public class MockVideoData : IVideoData
    {
        private List<Video> videos;

        public MockVideoData()
        {
            videos = new List<Video>
            {
                new Video{ Id=1, Title="3:10 to Yuma",Genre=Models.Genres.Romance},
                new Video{ Id=2, Title="Transporter",Genre=Models.Genres.Action},
                new Video{ Id=3, Title="Death Race",Genre=Models.Genres.Action}
            };

        }

        public Video Get(int id)
        {
            return videos.FirstOrDefault(v=>v.Id.Equals(id));  
        }

        public IEnumerable<Video> GetAll()
        {
            return videos;
        }
    }
}
