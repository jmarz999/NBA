using System;
using System.Collections.Generic;
using System.Text;
using NBA.Services.GameService.Dto;

namespace NBA.Services.StatService.Dto
{
    public class StatDto
    {
        public int Id { get; set; }
        public int? Ast { get; set; }
        public int? Blk { get; set; }
        public double? Fg3_pct { get; set; }
        public int? Fg3a { get; set; }
        public int? Fg3m { get; set; }
        public double? Fg_pct { get; set; }
        public int? Fga { get; set; }
        public int? Fgm { get; set; }
        public double? Ft_pct { get; set; }
        public int? Fta { get; set; }
        public GameDto Game { get; set; }
        public string? Min { get; set; }
        public int? Oreb { get; set; }
        public int? Pf { get; set; }
        public PlayerDto Player { get; set; }
        public int? Pts { get; set; }
        public int? Reb { get; set; }
        public int? Stl { get; set; }
        public TeamDto Team { get; set; }
        public int? Turnover { get; set; }
    }
}
