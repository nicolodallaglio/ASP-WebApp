using System.Data;

namespace WebApp.Models.Services.Infrastructure
{
    public interface IDatabaseAccessor
    {
        DataSet Query(string query);
    }
}