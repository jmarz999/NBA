using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Models
{
    public class Stat
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
        public Game Game { get; set; }
        public string? Min { get; set; }
        public int? Oreb { get; set; }
        public int? Pf { get; set; }
        public Player Player { get; set; }
        public int? Pts { get; set; }
        public int? Reb { get; set; }
        public int? Stl { get; set; }
        public Team Team { get; set; }
        public int? Turnover { get; set; }
    }
}
