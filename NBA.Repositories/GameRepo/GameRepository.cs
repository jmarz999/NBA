using NBA.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NBA.Repositories
{
    public class GameRepository : IGameRepository
    {
        public async Task<Game> GetAllGames(int page, int per_page, [FromUri] Game[] dates, [FromUri] Game[] seasons, [FromUri] Game[] team_ids, bool postseason, DateTime start_date, DateTime end_date)
        {
            try
            {
                var url = $"https://www.balldontlie.io/api/v1/games/?seasons={seasons}&team_ids={team_ids}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new Game();

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Game>(json);
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
