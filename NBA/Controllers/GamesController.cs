using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NBA.Models;
using NBA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

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
        public async Task<ActionResult> GetAll(int page, int per_page, [FromUri] Game[] dates, [FromUri] Game[] seasons, [FromUri] Game[] team_ids, bool postseason, DateTime start_date, DateTime end_date)
        {
            var data = await gameAppService.GetAllGames(page, per_page, dates, seasons, team_ids, postseason, start_date, end_date);

            return Ok(data);
        }
    }
}
