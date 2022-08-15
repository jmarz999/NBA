using NBA.Models;
using NBA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace NBA.Services
{
    public class GameAppService : IGameAppService
    {
        private readonly IGameRepository gameRepository;

        public GameAppService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public Task<Game> GetAllGames(int page, int per_page, [FromUri] Game[] dates, [FromUri] Game[] seasons, [FromUri] Game[] team_ids, bool postseason, DateTime start_date, DateTime end_date)
        {
            return gameRepository.GetAllGames(page, per_page, dates, seasons, team_ids, postseason, start_date, end_date);
        }
    }
}
