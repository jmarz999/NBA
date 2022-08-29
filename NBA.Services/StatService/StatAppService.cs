using System.Threading.Tasks;
using NBA.Models;
using NBA.Repositories;

namespace NBA.Services
{
    public class StatAppService : IStatAppService
    {
        private readonly IStatRepository statRepository;

        public StatAppService(IStatRepository statRepository)
        {
            this.statRepository = statRepository;
        }

        public Task<DataStats> GetAllStats(StatDto statDto)
        {
            return statRepository.GetAllStats(statDto.Page, statDto.Per_page, statDto.Dates, statDto.Start_date, statDto.End_date, statDto.Seasons, statDto.Game_ids, statDto.Player_ids, statDto.Postseason);
        }
    }
}
