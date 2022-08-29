using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBA.Services;

namespace NBA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SeasonAverageController : ControllerBase
    {
        private readonly ISeasonAverageAppService seasonAverageAppService;

        public SeasonAverageController(ISeasonAverageAppService seasonAverageAppService)
        {
            this.seasonAverageAppService = seasonAverageAppService;
        }

        [HttpPost]
        public async Task<ActionResult> GetAverages(StatDto dto)
        {
            var data = await seasonAverageAppService.GetAverages(dto);
            return Ok(data);
        }
    }
}