using Microsoft.AspNetCore.Mvc;
using Game.BL.Contracts;

namespace GameApp.Controllers
{
    public class GameController : Controller
    {
        private IVideoGameService _videoGameService;

        // Conctructor
        public GameController(IVideoGameService videoGameService)
        {
            _videoGameService = videoGameService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VideoGame()
        {
            var games = _videoGameService.GetAll();
            return View(games);
        }
    }
}
