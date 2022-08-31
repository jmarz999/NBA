using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Services.SeasonAverageService;

namespace NBA.Services
{
    public interface ISeasonAverageAppService
    {
        Task<List<SeasonAverageDto>> GetAverages(StatInput dto);
    }
}
