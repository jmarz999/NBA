using System;
using System.Net.Http;
using System.Threading.Tasks;
using NBA.Models;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public class SeasonAverageRepository : ISeasonAverageRepository
    {
        public async Task<DataSeasonAverage> GetAverages(int season, int[] player_ids)
        {
            try
            {
                string player_idsArray = string.Empty;
                
                foreach (var id in player_ids)
                {
                    player_idsArray += $"&player_Ids[]={id}";
                }
                
                var url = $"https://www.balldontlie.io/api/v1/games/?season={season}{player_idsArray}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new DataSeasonAverage();


                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<DataSeasonAverage>(json);
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