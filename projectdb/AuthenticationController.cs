using System;
using Microsoft.Data.SqlClient;

namespace projectdb
{
    public class AuthenticationController
    {
        private readonly DatabaseService _dbService;

        public AuthenticationController()
        {
            _dbService = new DatabaseService();
        }

        public bool CreateAccount(string firstName, string lastName, string email, string password, string phone, string addressName, string lat, string lon)
        {
            try
            {
                using (SqlConnection connection = _dbService.GetConnection())
                {
                    connection.Open();

                    string query = @"INSERT INTO Users (Email, Password, Role, FirstName, LastName, Phone, AddressName, Lat, Long) 
                                     VALUES (@Email, @Password, 'User', @FirstName, @LastName, @Phone, @AddressName, @Lat, @Long)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@AddressName", addressName);
                        command.Parameters.AddWithValue("@Lat", lat);
                        command.Parameters.AddWithValue("@Long", lon);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Login(string email, string password)
        {
            try
            {
                using (SqlConnection connection = _dbService.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}