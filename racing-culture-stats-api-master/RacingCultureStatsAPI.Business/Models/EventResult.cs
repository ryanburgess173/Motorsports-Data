using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    public class EventResult
    {
        public int EventResultID { get; set; }
        public Event FeaturedEvent { get; set; }
        public Driver ResultDriver { get; set; }
        public Team ResultTeam { get; set; }
        public CarType TypeOfCar { get; set; }
        public int StartPosition { get; set; }
        public int FinishPosition { get; set; }
        public int LapsLed { get; set; }
    }
}