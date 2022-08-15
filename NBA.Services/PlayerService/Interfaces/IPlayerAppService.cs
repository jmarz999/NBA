using NBA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Services
{
    public interface IPlayerAppService
    {
        Task<DataPlayers> GetAllPlayers(int page, int per_page, string search);
        Task<Player> GetPlayerID(int id);
    }
}
