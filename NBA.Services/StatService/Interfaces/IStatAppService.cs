using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NBA.Models;

namespace NBA.Services
{
    public interface IStatAppService
    {
        public Task<DataStats> GetAllStats(StatDto statDto);
    }
}
