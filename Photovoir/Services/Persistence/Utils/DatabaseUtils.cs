using Microsoft.Extensions.Configuration;
using Photovoir.Settings;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Services.Utils
{
    public class DatabaseUtils
    {
        private readonly string _connectionString;

        public DatabaseUtils(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Retrieves Connection string to database
        public string ConnectionString()
        {
            return _connectionString;
        }

        // Creates connection to database
        public DbConnection CreateConnection()
        {
            return CreateConnection(ConnectionString());
        }

        // Creates connection to database
        public DbConnection CreateConnection(string _connection)
        {
            if (_connection is null)
                throw new ArgumentNullException(nameof(_connection));

            DbProviderFactory factory = DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");

            var connection = factory.CreateConnection();
            connection.ConnectionString = _connection;
            connection.Open();
            return connection;
        }
    }
}
