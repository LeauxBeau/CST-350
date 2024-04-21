using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using RegisterAndLoginApp.Models;
using System.Configuration;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;

namespace RegisterAndLoginApp.Services
{
    public class SecurityDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Test; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
    }
    public bool FindUserByNameAndPassword(UserModel user)
    {
        //asume nothing is found
        bool success = false;

        //users prepared statements for security, @username @password are defines below
        string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username and password = @password";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(sqlStatement, connection);

            //define the values of the two placegiolders in the sqlStatement string
            command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.UserName;
            command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            };
        }
        return success;
    }
}
