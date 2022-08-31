using System;
using System.Collections.Generic;
using System.Text;
using NBA.Models;

namespace NBA.Services.GameService.Dto
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Home_team_score { get; set; }
        public int Visitor_team_score { get; set; }
        public int Season { get; set; }
        public int Period { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public bool Postseason { get; set; }
        public TeamDto Home_team { get; set; }
        public TeamDto Visitor_team { get; set; }
    }
}
