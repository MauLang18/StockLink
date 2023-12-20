using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace StockLink.Persistence.Context
{
    public class Application2DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Application2DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Connection3")!;
        }

        public IDbConnection CreateConnection => new SqlConnection(_connectionString);
    }
}
