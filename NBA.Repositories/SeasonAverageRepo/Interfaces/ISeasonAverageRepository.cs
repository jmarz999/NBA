using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;

namespace NBA.Repositories
{
    public interface ISeasonAverageRepository
    {
        Task<DataSeasonAverage> GetAverages(int season, int[] player_ids);
    }
}
