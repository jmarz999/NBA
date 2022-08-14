using NBA.Models;
using System.Threading.Tasks;

namespace NBA.Repositories
{
    public interface IPlayerRepository
    {
        Task<DataPlayers> GetAllPlayers(int page, int per_page, string search);
        Task<DataPlayers> GetPlayerID(int id);
    }
}
