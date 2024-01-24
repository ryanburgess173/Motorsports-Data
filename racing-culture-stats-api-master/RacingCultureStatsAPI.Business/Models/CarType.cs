using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCultureStatsAPI.Business.Models
{
    class CarType
    {
        public int CarTypeID { get; set; }
        public string CarTypeName { get; set; }
        public int CarTypeYearOfIntroduction { get; set; }
        public int CarTypeYearOfRetirement { get; set; }
    }
}
