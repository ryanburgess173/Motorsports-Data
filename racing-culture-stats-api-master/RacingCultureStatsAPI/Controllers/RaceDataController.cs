using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingCultureStatsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace RacingCultureStatsAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RaceDataController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetARace()
        {
            Race race = new Race
            {
                RaceName="Arizona 300", 
                RaceDate = new DateTime(2021, 11, 29),
                NumberOfLaps=312, 
                Winner="Kyle Busch", 
                Purse = 100293.54 
            };
            return Ok(race);
        }
    }
}
