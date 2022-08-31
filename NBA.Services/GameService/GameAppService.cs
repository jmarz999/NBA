using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Repositories;
using NBA.Services.GameService.Dto;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class GameAppService : IGameAppService
    {
        private readonly IGameRepository gameRepository;

        public GameAppService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public async Task<List<GameDto>> GetAllGames(GameInput dto)
        {
            if (dto.Team_ids.Any(x => x == 0))
            {
                throw new AppException("You must enter team id");
            }

            var result = await gameRepository.GetAllGames(dto.Page, dto.Per_page, dto.Dates, dto.Start_date, dto.End_date, dto.Seasons, dto.Team_ids, dto.Postseason);

            return result.Data.Select(x => Mapper.EntityToDto(x)).ToList();

        }

        public async Task<GameDto> GetGame(int id)
        {
            if (id == 0)
            {
                throw new AppException("You must enter game id");
            }

            var result = await gameRepository.GetGame(id);

            return Mapper.EntityToDto(result);
        }
    }
}