using PogrammingInCSharp.BaseBackend.Interfaces;
using PogrammingInCSharp.BaseBackend.Models;
using System.Data.SqlClient;

namespace PogrammingInCSharp.BaseBackend.Services;

public class UserService : IBaseService<User>
{
    private const string connectionString = "Data Source=.;Initial Catalog=ProgrammingInCSharp0407Db;Trusted_Connection=True;";

    public void Add(User user)
    {
        //Connect Db
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

    public void Delete(int id)
    {
        //Connect Db
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = $"delete dbo.[User] where Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            // Execute the insert query
            int rowsAffected = command.ExecuteNonQuery();

            //return rowsAffected > 0;
        }
    }

    public List<User> GetAll()
    {
        List<User> users = new List<User>();

        //Connect Db
        
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
                    NationalCode = reader["NationalCode"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString()
                };
                users.Add(user);
            }

        }

        //Return LIst<User>
        return users;
    }

    public void Update(User item)
    {
        //Connect Db
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = $"update dbo.[User] set PhoneNumber = @PhoneNumber,FirstName = @FirstName,LastName = @LastName, NationalCode = @NationalCode where Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@LastName", item.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
            command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
            command.Parameters.AddWithValue("@Id", item.Id);

            // Execute the insert query
            int rowsAffected = command.ExecuteNonQuery();

            //return rowsAffected > 0;
        }
    }
}
