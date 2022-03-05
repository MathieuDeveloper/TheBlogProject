using Microsoft.Extensions.Configuration;
using Npgsql;
using System;


namespace TheBlogProject.Data
{
    public class ConnectionService
    {
        public static string GetConnectionString(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
            return string.IsNullOrEmpty(databaseUrl) ? connectionString : BuildConnectionString(databaseUrl) ;  
        }
        private static string BuildConnectionString(string databaseUrl)
        {

        }
    }
}
