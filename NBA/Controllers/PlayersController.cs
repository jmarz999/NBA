using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult GetAll()
        {

            return Ok();
        }

        [HttpGet]
        public ActionResult GetById()
        {

            return Ok();
        }
    }
}
