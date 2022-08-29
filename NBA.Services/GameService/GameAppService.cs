using System.Linq;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Repositories;

namespace NBA.Services
{
    public class GameAppService : IGameAppService
    {
        private readonly IGameRepository gameRepository;

        public GameAppService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public Task<DataGames> GetAllGames(GameDto dto)
        {
            if (dto.Team_ids.Any(x => x == 0))
            {
                throw new AppException("You must enter team id");
            }
            return gameRepository.GetAllGames(dto.Page, dto.Per_page, dto.Dates, dto.End_date, dto.Start_date, dto.Seasons, dto.Team_ids, dto.Postseason);
        }

        public Task<Game> GetGame(int id)
        {
            if (id == 0)
            {
                throw new AppException("You must enter game id");
            }
            return gameRepository.GetGame(id);
        }
    }
}
