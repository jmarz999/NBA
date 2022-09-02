using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using NBA.Services.SeasonAverageService;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class SeasonAverageAppService : ISeasonAverageAppService
    {
        public async Task<List<SeasonAverageDto>> GetAverages(StatInput dto)
        {
            string player_idsArray = string.Empty;

            foreach (var id in dto.Player_ids)
            {
                player_idsArray += $"&player_Ids[]={id}";
            }

            var url = $"https://www.balldontlie.io/api/v1/games/?season={dto.Season}{player_idsArray}";

            var result = await NBAClient.Get<DataApiResponses<SeasonAverage>>(url);

            return result.Data.Select(x => x.EntityToDto()).ToList();
        }
    }
}