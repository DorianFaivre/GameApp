using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.BL.Contracts
{
    public interface IVideoGameService
    {
        public VideoGame Get(int id);

        public List<VideoGame> GetAll();

        public void Create(VideoGame videoGame);

        public void Delete(int id);

        public VideoGame Update(int id, VideoGame updateVideoGame);

    }
}
