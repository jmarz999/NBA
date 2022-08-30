using System.Collections.Generic;
using System.Threading.Tasks;

namespace NBA.Services
{
    public interface IPlayerAppService
    {
        Task<List<PlayerDto>> GetAllPlayers(int? page, int? per_page, string search);
        Task<PlayerDto> GetPlayerID(int id);
    }
}
