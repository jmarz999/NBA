using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Repositories;
using NBA.Services.StatService.Dto;
using NBA.Services.Utils;

namespace NBA.Services
{
    public class StatAppService : IStatAppService
    {
        private readonly IStatRepository statRepository;

        public StatAppService(IStatRepository statRepository)
        {
            this.statRepository = statRepository;
        }

        public async Task<List<StatDto>> GetAllStats(StatInput statDto)
        {
            var result = await statRepository.GetAllStats(statDto.Page, statDto.Per_page, statDto.Dates, statDto.Start_date, statDto.End_date, statDto.Seasons, statDto.Game_ids, statDto.Player_ids, statDto.Postseason);

            return result.Data.Select(x => Mapper.EntityToDto(x)).ToList();
        }
    }
}
