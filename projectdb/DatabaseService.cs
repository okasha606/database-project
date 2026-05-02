using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace projectdb
{
    public class DatabaseService
    {
        private readonly string _connectionString = @"Data Source=MAHMOUDBADWY\MSSQLSERVER01;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=0";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
