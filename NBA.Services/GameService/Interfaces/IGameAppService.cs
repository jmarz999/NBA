using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Services;
using NBA.Services.GameService.Dto;

namespace NBA.Services
{
    public interface IGameAppService
    {
        public Task<List<GameDto>> GetAllGames(GameInput gameDto);
        public Task<GameDto> GetGame(int id);
    }
}
