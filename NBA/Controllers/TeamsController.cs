using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBA.Services;

namespace NBA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamAppService teamAppService;

        public TeamsController(ITeamAppService teamAppService)
        {
            this.teamAppService = teamAppService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll(int page, int per_page)
        {
            var data = await teamAppService.GetAllTeams(page, per_page);
            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult> GetId(int id)
        {
            var data = await teamAppService.GetTeam(id);
            return Ok(data);
        }
    }
}