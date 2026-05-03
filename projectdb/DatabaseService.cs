using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace projectdb
{
    public class DatabaseService
    {
        private string connectionStringKamal = "Server=DESKTOP-9VOLK8E;Database=project;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionStringKamal);
        }
    }
}
