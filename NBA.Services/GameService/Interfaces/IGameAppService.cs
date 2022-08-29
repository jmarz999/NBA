using System;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Services;

namespace NBA.Services
{
    public interface IGameAppService
    {
        public Task<DataGames> GetAllGames(GameDto gameDto);
        public Task<Game> GetGame(int id);
    }
}
