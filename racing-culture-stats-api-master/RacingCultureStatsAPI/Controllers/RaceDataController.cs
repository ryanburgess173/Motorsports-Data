using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using RacingCultureStatsAPI.Business.Models;
using RacingCultureStatsAPI.DAL.Services;
using RacingCultureStatsAPI.DAL;

namespace RacingCultureStatsAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RaceDataController : ControllerBase
    {
        [HttpGet]
        [Route("GetRacesForASeason")]
        public async Task<ActionResult> GetRacesForASeason(int year)
        {
            try
            {
                Connection conn = new Connection();
                EventService eventService = new EventService(conn.databaseConnection);
                List<Event> events = await eventService.SelectAllEventsByYear(year);
                string jsonString = JsonSerializer.Serialize(events);
                return Ok(jsonString);
            }catch (Exception e){
                Console.WriteLine(e.ToString());
                return StatusCode(500, new { error = e.Message });
            }
        }
    }
}
