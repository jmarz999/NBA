using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public class StatRepository : IStatRepository
    {
        public async Task<DataStats> GetAllStats(int page, int perPage, string[] dates, string startDate, string endDate, int[] seasons, int[] gameId, int[] player_ids, bool postseason)
        {
            try
            {
                string seasons1 = string.Empty;
                string playerIds1 = string.Empty;
                var url = $"https://www.balldontlie.io/api/v1/stats?page={page}{seasons1}{playerIds1}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new DataStats();

                foreach (var season in seasons)
                {
                    seasons1 += $"&season[]={season}";
                }

                foreach (var id in player_ids)
                {
                    playerIds1 += $"&player_ids[]={playerIds1}";
                }

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<DataStats>(json);
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
