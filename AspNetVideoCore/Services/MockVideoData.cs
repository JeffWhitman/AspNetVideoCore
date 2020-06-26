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
                new Video{ Id=1, Title="3:10 to Yuma",GenreId=1},
                new Video{ Id=2, Title="Transporter",GenreId=2},
                new Video{ Id=3, Title="Death Race",GenreId=3}
            };

        }
        public IEnumerable<Video> GetAll()
        {
            return videos;
        }
    }
}
