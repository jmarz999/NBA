using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Models.ApiResponses;
using NBA.Repositories;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public async Task<DataTeams> GetAllTeams(int page, int per_page)
        {
            try
            {
                var url = $"https://www.balldontlie.io/api/v1/teams/?page={page}&per_page={per_page}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new DataTeams();

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<DataTeams>(json);
                }
                return data;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task<Team> GetTeam(int id)
        {
            try
            {
                var url = $"https://www.balldontlie.io/api/v1/teams/{id}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var data = new Team();

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Team>(json);
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
