using EVApiMOTC.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace EVApiMOTC.Repositories
{
    /// <summary>
    /// Repository class for fetching the latest operator data from the database.
    /// </summary>
    public class EVOperatorRepository
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="EVOperatorRepository"/> class.
        /// </summary>
        /// <param name="configuration">The configuration used to get the database connection string.</param>
        public EVOperatorRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MOTCApiDatabase");
        }

        /// <summary>
        /// Fetches the latest operator data from the database.
        /// </summary>
        /// <returns>The latest operator data.</returns>
        public EV_OperatorData FetchLatestOperatorData()
        {
            using var db = new SqlConnection(_connectionString);
            const string sql = "SELECT TOP 1 * FROM EV_OperatorData WHERE IsDelete != 1 ORDER BY UKey DESC";
            return db.QueryFirstOrDefault<EV_OperatorData>(sql);
        }
    }
}
