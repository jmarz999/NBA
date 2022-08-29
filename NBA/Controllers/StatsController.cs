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
    public class StatsController : ControllerBase
    {
        private readonly IStatAppService statAppService;

        public StatsController(IStatAppService statAppService)
        {
            this.statAppService = statAppService;
        }

        [HttpPost]
        public async Task<ActionResult> GetAll(StatDto statDto)
        {
            var data = await statAppService.GetAllStats(statDto);
            return Ok(data);
        }
    }
}
