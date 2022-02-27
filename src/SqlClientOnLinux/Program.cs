namespace SqlClientOnLinux;

using System;
using Microsoft.Data.SqlClient;

public static class Program
{
    public static void Main()
    {
        using var conn = new SqlConnection("Server=lpc:(local);Integrated Security=True");
        using var comm = conn.CreateCommand();

        comm.CommandText = "SELECT 1 AS [Test];";

        conn.Open();
        Console.WriteLine(comm.ExecuteScalar());
    }
}
