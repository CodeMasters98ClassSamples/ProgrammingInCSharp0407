using PogrammingInCSharp.BaseBackend.Interfaces;
using PogrammingInCSharp.BaseBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PogrammingInCSharp.BaseBackend.Services;

public class UserService : IBaseService<User>
{
    public void Add(User user)
    {

        //Connect Db
        const string connectionString = "Data Source=.;Initial Catalog=ProgrammingInCSharp0407Db;Trusted_Connection=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = $"INSERT INTO dbo.[User] (FirstName,LastName,PhoneNumber,NationalCode) " +
                         "VALUES (@FirstName, @LastName, @PhoneNumber, @NationalCode)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", user.FirstName);
            command.Parameters.AddWithValue("@LastName", user.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            command.Parameters.AddWithValue("@NationalCode", user.NationalCode);

            // Execute the insert query
            int rowsAffected = command.ExecuteNonQuery();

            //return rowsAffected > 0;
        }
    }

    public List<User> GetAll()
    {
        List<User> users = new List<User>();

        //Connect Db
        const string connectionString = "Data Source=.;Initial Catalog=ProgrammingInCSharp0407Db;Trusted_Connection=True;";

        //SqlServer Command or query -> Select Users From Db

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM dbo.[User]";
            SqlCommand command = new SqlCommand(query, connection);

            // Create a data reader to fetch the data
            SqlDataReader reader = command.ExecuteReader();

            //Result Database -> Map to instace (object)
            while (reader.Read())
            {
                User user = new User()
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                };
                users.Add(user);
            }

        }

        //Return LIst<User>
        return users;
    }
}
