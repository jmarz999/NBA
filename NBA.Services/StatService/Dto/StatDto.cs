namespace NBA.Services
{
    public class StatDto
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public string[] Dates { get; set; }
        public int[] Seasons { get; set; }
        public int Season { get; set; }
        public int[] Player_ids { get; set; }
        public int[] Game_ids { get; set; }
        public bool Postseason { get; set; }
        public string Start_date { get; set; }
        public string End_date { get; set; }
    }
}