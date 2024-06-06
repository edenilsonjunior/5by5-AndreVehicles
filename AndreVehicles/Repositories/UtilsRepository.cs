using Dapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Repositories;

public static class UtilsRepository<T>
{
    private static string _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;

    public static bool Insert(string query, object obj)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        return connection.Execute(query, obj) > 0;
    }

    public static int InsertWithScalar(string query, object obj)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        return connection.ExecuteScalar<int>(query, obj);
    }

    public static List<T> GetAll(string query)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        return connection.Query<T>(query).ToList();
    }
}
