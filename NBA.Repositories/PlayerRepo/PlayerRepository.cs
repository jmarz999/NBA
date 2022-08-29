using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Models.ApiResponses;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public async Task<DataPlayers> GetAllPlayers(int? page, int? per_page, string search)
        {
            try
            {
                var url = $"https://www.balldontlie.io/api/v1/players?search={search}&per_page={per_page}&page={page}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new DataPlayers();

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    data = JsonConvert.DeserializeObject<DataPlayers>(json);
                }

                return data;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task<Player> GetPlayerID(int id)
        {
            try
            {
                var url = $"https://www.balldontlie.io/api/v1/players/237";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new Player();

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Player>(json);
                }

                return data;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
