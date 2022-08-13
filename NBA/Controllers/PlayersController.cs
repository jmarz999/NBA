using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NBA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
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
