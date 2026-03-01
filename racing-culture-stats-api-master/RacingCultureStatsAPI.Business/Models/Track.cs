using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    public class Track
    {
        public int TrackID { get; set; }
        public string TrackName { get; set; }
        public string TrackCity { get; set; }
        public string TrackState { get; set; }
        public string TrackCountry { get; set; }
        public int YearFounded { get; set; }

        public Track(int id, string name, string city,
            string state, string country, int year){
                this.TrackID = id;
                this.TrackName = name;
                this.TrackCity = city;
                this.TrackState = state;
                this.TrackCountry = country;
                this.YearFounded = year;
        }
    }
}