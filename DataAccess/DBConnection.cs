using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBConnection
    {
        public DBProvider DataProvider { get; set; } = null;
        public SqlConnection connection = null;

        public string GetConnectionString()
        {
            string connectionString;

            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }
        public DBConnection()
        {
            var connectionString = GetConnectionString();
            DataProvider = new DBProvider(connectionString);
        }

        public void CloseConnection() => DataProvider.CloseConnection(connection);
    }
}
