using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Models.ApiResponses
{
    public class DataTeams
    {
        public List<Team> Data { get; set; }
        public Meta Meta { get; set; }
    }
}
