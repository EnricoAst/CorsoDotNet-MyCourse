using System.Data;
using Microsoft.Data.Sqlite;

namespace MyCourse.Models.Services.Infrastructure
{
    public class SqlLiteDatabaseConnection : IDatabaseConnection
    {
        public DataSet Query(string query)
        {
            using (var conn = new SqliteConnection("Data Source = Data/MyCourse.db")) 
            {
                conn.Open();
                using (var cmd = new SqliteCommand(query, conn)) 
                {
                    using (var reader = cmd.ExecuteReader()) 
                    {
                        var dataSet = new DataSet();
                        var dataTable = new DataTable();
                        dataSet.Tables.Add(dataTable);
                        dataTable.Load(reader);
                        return dataSet;
                    }
                }
            }
        }
    }
}