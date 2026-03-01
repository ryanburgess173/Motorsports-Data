using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DotNetEnv;

namespace RacingCultureStatsAPI.DAL
{
    public class Connection
    {
        public SqlConnectionStringBuilder connectionStringBuilder { get; set; }
        public string connectionString { get; set; }
        public SqlConnection databaseConnection { get; set; }
        public string sqlStatement { get; set; }
        public SqlCommand sqlCommand { get; set; }
        public string dbServer { get; set; }
        public string dbName { get; set; }
        public string dbUserID { get; set; }
        public string dbUserPasswd { get; set; }

        public Connection()
        {
            DotNetEnv.Env.Load();
            this.dbServer = Environment.GetEnvironmentVariable("DBSERVER");
            this.dbName = Environment.GetEnvironmentVariable("DATABASE");
            this.dbUserID = Environment.GetEnvironmentVariable("USERID");
            this.dbUserPasswd = Environment.GetEnvironmentVariable("PASSWORD");

            this.connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = this.dbServer,
                UserID = this.dbUserID,
                Password = this.dbUserPasswd,
                InitialCatalog = this.dbName
            };

            this.connectionString = connectionStringBuilder.ConnectionString;
            this.databaseConnection = new SqlConnection(this.connectionString);
        }
    }
}