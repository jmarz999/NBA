using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerRepository(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task GetAllPlayers()
        {
            var url = "https://www.balldontlie.io/api/v1/players";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
