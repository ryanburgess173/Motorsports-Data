namespace RacingCultureStatsAPI.Business.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int YearFounded { get; set; }
        public string StateBased { get; set; }
        public string CountryBased { get; set; }
    }
}