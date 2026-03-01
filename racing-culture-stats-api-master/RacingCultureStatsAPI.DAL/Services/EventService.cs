using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using RacingCultureStatsAPI.Business.Models;

namespace RacingCultureStatsAPI.DAL.Services
{
    public class EventService
    {
        public SqlConnection dbConnection { get; set; }
        public TrackService trackService { get; set; }

        public EventService(SqlConnection connection)
        {
            this.dbConnection = connection;
            this.trackService = new TrackService(connection);
        }

        public async Task<List<Event>> SelectAllEventsByYear(int year)
        {
            List<Event> events = new List<Event>();
            Event racingEvent;
            Track? associatedTrack = null;
            try{
                await this.dbConnection.OpenAsync();
                var sql = "EXEC dbo.SelectAllEventsByYear @Year = " + year.ToString() + ";";
                var command = new SqlCommand(sql, this.dbConnection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    associatedTrack = await this.trackService.SelectTrackByID(reader.GetInt32(4));
                    racingEvent = new Event(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        associatedTrack,
                        reader.GetDateTime(5),
                        reader.GetInt32(6)
                    );
                    events.Add(racingEvent);
                }
                this.dbConnection.Close();
                return events;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return events;
            }
        }
    }
}