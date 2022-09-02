using NBA.Models;
using NBA.Services.GameService.Dto;
using NBA.Services.SeasonAverageService;
using NBA.Services.StatService.Dto;

namespace NBA.Services.Utils
{
    public static class Mapper
    {
        public static PlayerDto EntityToDto(this Player entity)
        {
            return new PlayerDto
            {
                Id = entity.Id,
                First_name = entity.First_name,
                Last_name = entity.Last_name,
                Position = entity.Position,
                Height_feet = entity.Height_feet,
                Height_inches = entity.Height_inches,
                Weight_pounds = entity.Weight_pounds,
                Team = entity.Team?.EntityToDto(),
            };
        }

        public static TeamDto EntityToDto(this Team entity)
        {
            return new TeamDto
            {
                Id = entity.Id,
                Abbreviation = entity.Abbreviation,
                City = entity.City,
                Conference = entity.Conference,
                Division = entity.Division,
                Full_name = entity.Full_name,
                Name = entity.Name
            };
        }

        public static GameDto EntityToDto(this Game entity)
        {
            return new GameDto
            {
                Id = entity.Id,
                Date = entity.Date,
                Home_team = entity.Home_team?.EntityToDto(),
                Home_team_score = entity.Home_team_score,
                Period = entity.Period,
                Postseason = entity.Postseason,
                Season = entity.Season,
                Status = entity.Status,
                Time = entity.Time,
                Visitor_team = entity.Visitor_team?.EntityToDto(),
                Visitor_team_score = entity.Visitor_team_score
            };
        }

        public static SeasonAverageDto EntityToDto(this SeasonAverage entity)
        {
            return new SeasonAverageDto
            {
                Ast = entity.Ast,
                Fg3a = entity.Fg3a,
                Blk = entity.Blk,
                Dreb = entity.Dreb,
                Fg3m = entity.Fg3m,
                Fg3_pct = entity.Fg3_pct,
                Fga = entity.Fga,
                Fgm = entity.Fgm,
                Fg_pct = entity.Fg_pct,
                Fta = entity.Fta,
                Ftm = entity.Ftm,
                Ft_pct = entity.Ft_pct,
                Min = entity.Min,
                Oreb = entity.Oreb,
                Pf = entity.Pf,
                Pts = entity.Pts,
                Stl = entity.Stl,
                Reb = entity.Reb,
                Trunover = entity.Trunover,
                Season = entity.Season,
                Games_played = entity.Games_played,
                Player_id = entity.Player_id
            };
        }

        public static StatDto EntityToDto(this Stat entity)
        {
            return new StatDto
            {
                Id = entity.Id,
                Game = entity.Game?.EntityToDto(),
                Player = entity.Player?.EntityToDto(),
                Team = entity.Team?.EntityToDto(),
                Turnover = entity.Turnover
            };
        }
    }
}
