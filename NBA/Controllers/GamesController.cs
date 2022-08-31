using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBA.Services;

namespace NBA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameAppService gameAppService;

        public GamesController(IGameAppService gameAppService)
        {
            this.gameAppService = gameAppService;
        }

        [HttpPost]
        public async Task<ActionResult> GetAll(GameInput gameDto)
        {
            var data = await gameAppService.GetAllGames(gameDto);

            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult> GetGame(int id)
        {
            var data = await gameAppService.GetGame(id);

            return Ok(data);
        }

    }
}