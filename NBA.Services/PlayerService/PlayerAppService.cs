using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Repositories;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class PlayerAppService : IPlayerAppService
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerAppService(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task<List<PlayerDto>> GetAllPlayers(int? page, int? per_page, string search)
        {
            if(search == null)
            {
                throw new AppException("You must enter player info");
            }

            var players = await playerRepository.GetAllPlayers(page, per_page, search);

            return players.Data.Select(x => Mapper.EntityToDto(x)).ToList();
        }

        public async Task<PlayerDto> GetPlayerID(int id)
        {
            if (id == 0)
            {
                throw new AppException("You must enter player id");
            }
            
            var player = await playerRepository.GetPlayerID(id);

            return Mapper.EntityToDto(player);
        }
    }
}
