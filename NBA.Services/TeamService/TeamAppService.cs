using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class TeamAppService : ITeamAppService
    { 
        public async Task<List<TeamDto>> GetAllTeams(int page, int per_page)
        {
            var url = $"https://www.balldontlie.io/api/v1/teams/?page={page}&per_page={per_page}";

            var result = await NBAClient.Get<DataApiResponses<Team>>(url);

            return result.Data.Select(x => x.EntityToDto()).ToList();
        }

        public async Task<TeamDto> GetTeam(int id)
        {
            var url = $"https://www.balldontlie.io/api/v1/teams/{id}";

            if (id == 0)
            {
                throw new AppException("You must enter team id");
            }

            var result = await NBAClient.Get<Team>(url);

            return result.EntityToDto();
        }
    }
}
