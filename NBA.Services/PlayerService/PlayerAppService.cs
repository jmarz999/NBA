using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public Task<DataPlayers> GetAllPlayers(int page, int per_page, string search)
        {
            return playerRepository.GetAllPlayers(page, per_page, search);
        }

        public Task<Player> GetPlayerID(int id)
        {
            return playerRepository.GetPlayerID(id);
        }
    }
}
