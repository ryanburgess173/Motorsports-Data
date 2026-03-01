using System;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using RacingCultureStatsAPI.Business.Models;

namespace RacingCultureStatsAPI.DAL
{
    public class TrackService
    {
        public SqlConnection dbConnection { get; set; }

        public TrackService(SqlConnection connection)
        {
            this.dbConnection = connection;
        }

        public async Task<Track?> SelectTrackByID(int id)
        {
            Track? trackFound = null;
            try{
                await this.dbConnection.OpenAsync();
                var sql = "EXEC dbo.SelectTrackByID @TrackID = " + id.ToString() + ";";
                var command = new SqlCommand(sql, this.dbConnection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    trackFound = new Track(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetInt32(5)
                    );
                }
                return trackFound;
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            } 
        }
    }
}