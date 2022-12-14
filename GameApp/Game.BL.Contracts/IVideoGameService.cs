using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL.Contracts
{
    public interface IVideoGameService
    {
        public VideoGame Get(int id);

        public List<VideoGame> GetAll();

        public VideoGame Create(VideoGame videoGame);

        public void Delete(int id);

        public VideoGame Update(VideoGame updateVideoGame);

        public double AverageGrade(VideoGame videoGame);
    }
}
