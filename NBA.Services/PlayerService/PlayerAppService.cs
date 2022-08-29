using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Repositories;

namespace NBA.Services
{
    public class PlayerAppService : IPlayerAppService
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerAppService(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public Task<DataPlayers> GetAllPlayers(int? page, int? per_page, string search)
        {
            if(search == null)
            {
                throw new AppException("You must enter player info");
            }
            return playerRepository.GetAllPlayers(page, per_page, search);
        }

        public Task<Player> GetPlayerID(int id)
        {
            if (id == 0)
            {
                throw new AppException("You must enter player id");
            }
            else
                return playerRepository.GetPlayerID(id);
        }
    }
}
