using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Repositories;
using NBA.Services.SeasonAverageService;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class SeasonAverageAppService : ISeasonAverageAppService
    {
        private readonly ISeasonAverageRepository seasonAverageRepository;

        public SeasonAverageAppService(ISeasonAverageRepository seasonAverageRepository)
        {
            this.seasonAverageRepository = seasonAverageRepository;
        }

        public async Task<List<SeasonAverageDto>> GetAverages(StatInput dto)
        {
            var result = await seasonAverageRepository.GetAverages(dto.Season, dto.Player_ids);

            return result.Data.Select(x => Mapper.EntityToDto(x)).ToList();
        }
    }
}