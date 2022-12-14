using Game.BL.Contracts;
using Game.Entities;
using Game.DAL;
using System.Diagnostics;

namespace Game.BL
{
    public class VideoGameService : IVideoGameService
    {
        private Context _videoGameContext;

        public VideoGameService(Context context)
        {
            _videoGameContext = context;
        }
        public VideoGame Create(VideoGame videogame)
        {
            var entity = _videoGameContext.VideoGame.Add(videogame);
            _videoGameContext.SaveChanges();
            return entity.Entity;
        }

        public VideoGame Get(int id)
        {
            //var getComment = _commentContext.Comment.Find(id);
            var getVideoGame = _videoGameContext.VideoGame.FirstOrDefault(x => x.Id == id);
            if (getVideoGame == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                return getVideoGame;
            }
        }


        public List<VideoGame> GetAll()
        {
            return _videoGameContext
                .VideoGame
                .ToList();
        }


        public void Delete(int id)
        {
            VideoGame videoGameToDelete = Get(id);
            var entity = _videoGameContext.VideoGame.Remove(videoGameToDelete);
            _videoGameContext.SaveChanges();
        }

        public VideoGame Update(VideoGame updateVideoGame)
        {
            var entity = _videoGameContext.VideoGame.Update(updateVideoGame);
            _videoGameContext.SaveChanges();
            return entity.Entity;
        }

        public double AverageGrade(VideoGame videoGame)
        {
            double noteMoyenne = videoGame.grade.Average();
            return noteMoyenne;
        }
    }
}