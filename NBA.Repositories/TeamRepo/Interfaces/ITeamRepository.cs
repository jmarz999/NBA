using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Models.ApiResponses;

namespace NBA.Repositories
{
    public interface ITeamRepository
    {
        Task<DataTeams> GetAllTeams(int page, int per_page);
        Task<Team> GetTeam(int id);
    }
}
