using System;
using System.Net.Http;
using System.Threading.Tasks;
using NBA.Helpers;
using NBA.Models;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public class GameRepository : IGameRepository
    {
        public async Task<DataGames> GetAllGames(int page, int perPage, string[]? dates, string startDate, string endDate, string[] seasons, int[] teamId, bool postseason)
        {
            try
            {
                string seasons1 = string.Empty;

                string teamIds1 = string.Empty;

                string seasonDates = string.Empty;

                //foreach (var date in dates)
                //{
                //    seasonDates += $"&dates[]={date}";
                //}

                foreach (var season in seasons)
                {
                    seasons1 += $"&seasons[]={season}";
                }

                foreach (var id in teamId)
                {
                    teamIds1 += $"&team_ids[]={id}";
                }

                var url = $"https://www.balldontlie.io/api/v1/games?page={page}{seasons1}{teamIds1}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new DataGames();

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<DataGames>(json);
                }

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task<Game> GetGame(int id)
        {
            try
            {
                var url = $"https://www.balldontlie.io/api/v1/games/{id}";
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
