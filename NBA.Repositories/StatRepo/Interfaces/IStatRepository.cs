using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;

namespace NBA.Repositories
{
    public interface IStatRepository
    {
        public Task<DataStats> GetAllStats(int page, int perPage, string[] dates, string startDate, string endDate, int[] seasons, int[] gameId, int[] player_ids, bool postseason);
    }
}
