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

        public int? Login(string email, string password)
        {
            try
            {
                using (SqlConnection connection = _dbService.GetConnection())
                {
                    connection.Open();

                    // Assuming the primary key is named 'UserId'
                    string query = "SELECT UserId FROM Users WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show exception to help debug (e.g. if 'Id' is not the correct column name)
                System.Windows.Forms.MessageBox.Show("Database Error in Login: " + ex.Message);
                return null;
            }
        }
    }
}