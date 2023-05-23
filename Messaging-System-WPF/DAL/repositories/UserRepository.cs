using Messaging_System_WPF.model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_System_WPF.DAL
{
    public class UserRepository
    {
        private string connectionString;

        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<model.User> ReadUsers()
        {
            List<model.User> users = new List<model.User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT name, email, password, profile_picture FROM [User] " +
                               "WHERE name IS NOT NULL AND email IS NOT NULL AND password IS NOT NULL AND profile_picture IS NOT NULL;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        string email = reader.GetString(1);
                        string password = reader.GetString(2);
                        string profile_picture = reader.GetString(3);

                        model.User user = new model.User(name, email, password, profile_picture);
                        users.Add(user);
                    }

                    reader.Close();
                }
            }

            return users;
        }


        public void CreateUser(string name, string email,string password, string profile_picture)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [User] (profile_picture, name, email, password) VALUES (@ProfilePicture, @Name, @Email, @Password);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@ProfilePicture", profile_picture);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ValidateUserCredentials(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [User] WHERE email = @Email AND password = @Password;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
