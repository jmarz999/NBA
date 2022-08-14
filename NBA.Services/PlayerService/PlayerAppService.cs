using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
