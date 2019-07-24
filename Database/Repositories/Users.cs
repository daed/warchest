using Database.Objects;
using MySql.Data.MySqlClient;
using System;

namespace Database.Repositories
{
    public class Users
    {
        string connString;
        public Users(string _connString)
        {
            connString = _connString;
        }

        public User Find(string UserName)
        {
            var user = new User();
            using (var conn = new MySqlConnection(connString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users WHERE UserName = @UserName;";
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.UserName = reader["UserName"].ToString();
                    user.Passphrase = reader["Passphrase"].ToString();
                }
            }
            return user;
        }
    }
}
