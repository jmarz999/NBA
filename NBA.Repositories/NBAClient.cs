using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NBA.Models.ApiResponses;
using Newtonsoft.Json;

namespace NBA.Repositories
{
    public static class NBAClient
    {
        public static async Task<T> Get<T>(string url)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url).ConfigureAwait(false);
                T obj = (T)Activator.CreateInstance(typeof(T));

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    obj = JsonConvert.DeserializeObject<T>(json);
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
