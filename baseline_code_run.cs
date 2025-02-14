
using System;
using System.Data.SQLite;

namespace CRUDSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=mydatabase.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // CREATE operation
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Users (Username, Password) VALUES ('john.doe', 'password123')", connection))
                {
                    command.ExecuteNonQuery();
                }

                // READ operation
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Users", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Username: {reader["Username"]}, Password: {reader["Password"]}");
                        }
                    }
                }

                // UPDATE operation
                using (SQLiteCommand command = new SQLiteCommand("UPDATE Users SET Password = 'newpassword456' WHERE Username = 'john.doe'", connection))
                {
                    command.ExecuteNonQuery();
                }

                // DELETE operation
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Users WHERE Username = 'john.doe'", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
