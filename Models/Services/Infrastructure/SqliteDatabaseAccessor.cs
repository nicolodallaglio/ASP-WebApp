using System.Data;

namespace WebApp.Models.Services.Infrastructure
{
    public class SqliteDatabaseAccessor : IDatabaseAccessor
    {
        public DataSet Query(string query)
        {
            throw new NotImplementedException();
        }
    }
}