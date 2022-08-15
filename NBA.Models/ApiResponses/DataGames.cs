using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Models.ApiResponses
{
    public class DataGames
    {
        public List<Game> Data { get; set; }
        public Meta Meta { get; set; }
    }
}
