using NBA.Models;

namespace NBA.Services.Utils
{
    public static class Mapper
    {
        public static PlayerDto EntityToDto(Player entity)
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
                Team = EntityToDto(entity.Team),
            };
        }

        public static TeamDto EntityToDto(Team entity)
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
    }
}
