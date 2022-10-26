using System.Configuration;
using System.Data.SqlClient;

namespace launcher_master.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Launcher"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
