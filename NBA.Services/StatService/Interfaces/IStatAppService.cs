using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;
using NBA.Services.StatService.Dto;

namespace NBA.Services
{
    public interface IStatAppService
    {
        public Task<List<StatDto>> GetAllStats(StatInput statDto);
    }
}
