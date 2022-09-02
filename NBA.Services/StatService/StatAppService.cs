using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using NBA.Services.StatService.Dto;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class StatAppService : IStatAppService
    {
        public async Task<List<StatDto>> GetAllStats(StatInput statDto)
        {
            string seasons1 = string.Empty;
            string playerIds1 = string.Empty;
                
            foreach (var season in statDto.Seasons)
            {
                seasons1 += $"&season[]={season}";
            }

            foreach (var id in statDto.Player_ids)
            {
                playerIds1 += $"&player_ids[]={playerIds1}";
            }
            var url = $"https://www.balldontlie.io/api/v1/stats?page={statDto.Page}{seasons1}{playerIds1}";

            var result = await NBAClient.Get<DataApiResponses<Stat>>(url);

            return result.Data.Select(x => x.EntityToDto()).ToList();
        }
    }
}
