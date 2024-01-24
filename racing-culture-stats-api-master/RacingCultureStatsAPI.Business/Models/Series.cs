using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    class Series
    {
        public int SeriesID { get; set; }
        public string SeriesName { get; set; }
        public int CarTypeID { get; set; }
        public DateTime SeriesYear { get; set; }
    }
}
