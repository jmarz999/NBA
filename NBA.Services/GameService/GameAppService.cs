using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using NBA.Services.GameService.Dto;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class GameAppService : IGameAppService
    {
        public async Task<List<GameDto>> GetAllGames(GameInput dto)
        {
            string seasons1 = string.Empty;

            string teamIds1 = string.Empty;

            string seasonDates = string.Empty;

            //foreach (var date in dates)
            //{
            //    seasonDates += $"&dates[]={date}";
            //}

            foreach (var season in dto.Seasons)
            {
                seasons1 += $"&seasons[]={season}";
            }

            foreach (var id in dto.Team_ids)
            {
                teamIds1 += $"&team_ids[]={id}";
            }

            var url = $"https://www.balldontlie.io/api/v1/games?page={dto.Page}{seasons1}{teamIds1}";

            if (dto.Team_ids.Any(x => x == 0))
            {
                throw new AppException("You must enter team id");
            }

            var result = await NBAClient.Get<DataApiResponses<Game>>(url);

            return result.Data.Select(x => x.EntityToDto()).ToList();

        }

        public async Task<GameDto> GetGame(int id)
        {
            var url = $"https://www.balldontlie.io/api/v1/games/{id}";

            if (id == 0)
            {
                throw new AppException("You must enter game id");
            }

            var result = await NBAClient.Get<Game>(url);

            return Mapper.EntityToDto(result);
        }
    }
}