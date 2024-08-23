using System.Data;
using System.Data.SqlClient;

namespace GetMehrData
{
    public class MehrDbContext
    {
        public readonly string _connectionString;
        public MehrDbContext()
        {
            _connectionString = "Data Source=DESKTOP-NPREDR7\\sql2019;Initial Catalog=mehr2180;User ID=sa;Password=bastan.net.sqlserver;MultipleActiveResultSets=true";
            //_connectionString = appSettings.ConnectionStrings.MehrAccountingConnection;
        }

        public IDbConnection CreateConnection()
          => new SqlConnection(_connectionString);
    }
}
