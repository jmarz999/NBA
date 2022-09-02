using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class PlayerAppService : IPlayerAppService
    {
        public async Task<List<PlayerDto>> GetAllPlayers(int? page, int? per_page, string search)
        {
            var url = $"https://www.balldontlie.io/api/v1/players?search={search}&per_page={per_page}&page={page}";

            if (search == null)
            {
                throw new AppException("You must enter player info");
            }

            var players = await NBAClient.Get<DataApiResponses<Player>>(url);

            return players.Data.Select(x => x.EntityToDto()).ToList();

        }

        public async Task<PlayerDto> GetPlayerID(int id)
        {
            var url = $"https://www.balldontlie.io/api/v1/players/237";

            if (id == 0)
            {
                throw new AppException("You must enter player id");
            }

            var player = await NBAClient.Get<Player>(url);

            return player.EntityToDto();
        }
    }
}