namespace NBA.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Position { get; set; }
        public int? Height_feet { get; set; }
        public int? Height_inches { get; set; }
        public int? Weight_pounds { get; set; }

        public Team Team { get; set; }
    }
}