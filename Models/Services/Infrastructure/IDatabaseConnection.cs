using System.Data;

namespace MyCourse.Models.Services.Infrastructure
{
    public interface IDatabaseConnection
    {
        DataSet Query(string query);
    }
}