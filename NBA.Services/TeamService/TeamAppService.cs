using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Repositories;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class TeamAppService : ITeamAppService
    {
        private readonly ITeamRepository teamRepository;

        public TeamAppService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public async Task<List<TeamDto>> GetAllTeams(int page, int per_page)
        {
            var result = await teamRepository.GetAllTeams(page, per_page);

            return result.Data.Select(x => Mapper.EntityToDto(x)).ToList();
        }

        public async Task<TeamDto> GetTeam(int id)
        {
            if (id == 0)
            {
                throw new AppException("You must enter team id");
            }

            var result = await teamRepository.GetTeam(id);

            return Mapper.EntityToDto(result);
        }
    }
}
