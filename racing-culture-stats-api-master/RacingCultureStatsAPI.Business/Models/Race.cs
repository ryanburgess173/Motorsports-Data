using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacingCultureStatsAPI.Models
{
    public class Race
    {
        public string RaceName { get; set;}
        public DateTime RaceDate { get; set; }
        public int NumberOfLaps { get; set; }
        public string Winner { get; set; }
        public double Purse { get; set; }
    }
}
