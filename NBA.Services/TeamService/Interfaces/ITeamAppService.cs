using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Models.ApiResponses;

namespace NBA.Services
{
    public interface ITeamAppService
    {
        Task<List<TeamDto>> GetAllTeams(int page, int per_page);
        Task<TeamDto> GetTeam(int id);
    }
}
