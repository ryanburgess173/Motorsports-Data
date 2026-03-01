using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverMiddleName { get; set; }
        public string DriverLastName { get; set; }
        public DateTime DOB { get; set; }
        public string CityBorn { get; set; }
        public string StateBorn { get; set; }
        public string CountryBorn { get; set; }
    }
}
