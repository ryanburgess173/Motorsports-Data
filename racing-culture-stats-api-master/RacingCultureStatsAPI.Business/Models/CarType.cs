using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    public class CarType
    {
        public int CarTypeID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Series AssociatedSeries { get; set; }
    }
}
