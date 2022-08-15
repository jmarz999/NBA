using NBA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace NBA.Services
{
    public interface IGameAppService
    {
        public Task<Game> GetAllGames(int page, int per_page, [FromUri] Game[] dates, [FromUri] Game[] seasons, [FromUri] Game[] team_ids, bool postseason, DateTime start_date, DateTime end_date);
    }
}
