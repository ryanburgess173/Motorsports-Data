using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public Series Series { get; set; }
        public int EventLapCount { get; set; }
        public DateTime EventDate { get; set; }
        public Driver Winner { get; set; }
        public Driver PoleSitter { get; set; }
    }
}
