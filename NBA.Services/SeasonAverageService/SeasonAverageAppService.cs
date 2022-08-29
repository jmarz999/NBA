using System.Threading.Tasks;
using NBA.Models;
using NBA.Repositories;

namespace NBA.Services
{
    public class SeasonAverageAppService : ISeasonAverageAppService
    {
        private readonly ISeasonAverageRepository seasonAverageRepository;

        public SeasonAverageAppService(ISeasonAverageRepository seasonAverageRepository)
        {
            this.seasonAverageRepository = seasonAverageRepository;
        }

        public Task<DataSeasonAverage> GetAverages(StatDto dto)
        {
            return seasonAverageRepository.GetAverages(dto.Season, dto.Player_ids);
        }
    }
}