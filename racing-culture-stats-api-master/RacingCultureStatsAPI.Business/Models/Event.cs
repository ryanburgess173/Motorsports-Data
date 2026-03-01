using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventSponsor { get; set; }
        public int EventNumberOfLaps { get; set; }
        public Track EventTrack { get; set; }
        public DateTime EventDate { get; set; }
        public int IsNightRace { get; set; }

        public Event(int eId, string eName, string eSponsor,
            int eNOL, Track eventTrack, DateTime eventDate,
            int isNR){
                this.EventID = eId;
                this.EventName = eName;
                this.EventSponsor = eSponsor;
                this.EventNumberOfLaps = eNOL;
                this.EventTrack = eventTrack;
                this.EventDate = eventDate;
                this.IsNightRace = isNR; 
            }
    }
}
