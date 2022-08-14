using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NBA.Models;
using NBA.Services;

namespace NBA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerAppService playerAppService;

        public PlayersController(IPlayerAppService playerAppService)
        {
            this.playerAppService = playerAppService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll(int page, int per_page, string search)
        {
            var data = await playerAppService.GetAllPlayers(page,per_page,search);

            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult> GetById(int id)
        {
            var data = await playerAppService.GetPlayerID(id);
            return Ok(data);
        }
    }
}
