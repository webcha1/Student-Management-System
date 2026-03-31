
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentMarksSystem
{
    public class UserRepository
    {
        public User Authenticate(string username, string password)
        {
            User user = null;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString()
                    };
                }
            }

            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString()
                    });
                }
            }

            return users;
        }

        public void AddUser(User user)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Users (Username, Password, Role) 
                          VALUES (@Username, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Users SET 
                          Username = @Username, 
                          Password = @Password, 
                          Role = @Role
                          WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserID", userID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}