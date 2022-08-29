using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Services
{
    public class GameDto
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public string[] Dates { get; set; }
        public string Start_date { get; set; }
        public string End_date { get; set; }
        public string[] Seasons { get; set; }
        public int[] Team_ids { get; set; }
        public bool Postseason { get; set; }
    }
}
