namespace NBA.Models
{
    public class Game
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
        public HomeTeam Home_team { get; set; }
        public VisitorTeam Visitor_team { get; set; }
    }
}
