using System;
using System.Threading.Tasks;
using NBA.Models;

namespace NBA.Repositories
{
    public interface IGameRepository
    {
        public Task<DataGames> GetAllGames(int page, int perPage, string[] dates, string startDate, string endDate, string[] seasons, int[] teamId, bool postseason);
        public Task<Game> GetGame(int id);
    }
}
