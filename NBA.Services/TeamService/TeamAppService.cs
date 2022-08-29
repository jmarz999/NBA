using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using NBA.Services;

namespace NBA.Services
{
    public class TeamAppService : ITeamAppService
    {
        private readonly ITeamRepository teamRepository;

        public TeamAppService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public Task<DataTeams> GetAllTeams(int page, int per_page)
        {
            return teamRepository.GetAllTeams(page, per_page);
        }

        public Task<Team> GetTeam(int id)
        {
            if (id == 0)
            {
                throw new AppException("You must enter team id");
            }

            return teamRepository.GetTeam(id);
        }
    }
}
