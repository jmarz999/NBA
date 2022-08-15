using NBA.Models;
using NBA.Models.ApiResponses;
using System.Threading.Tasks;

namespace NBA.Repositories
{
    public interface IPlayerRepository
    {
        Task<DataPlayers> GetAllPlayers(int page, int per_page, string search);
        Task<Player> GetPlayerID(int id);
    }
}
