
using System;
using System.Data.SQLite;

namespace CRUD_Sqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=mydatabase.db;Version=3;";
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                // CREATE operation
                using (var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT, Age INTEGER)", con))
                {
                    cmd.ExecuteNonQuery();
                }

                // INSERT operation
                using (var cmd = new SQLiteCommand("INSERT INTO Users (Name, Age) VALUES ('John Doe', 30)", con))
                {
                    cmd.ExecuteNonQuery();
                }

                // READ operation
                using (var cmd = new SQLiteCommand("SELECT * FROM Users", con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                        }
                    }
                }

                // UPDATE operation
                using (var cmd = new SQLiteCommand("UPDATE Users SET Age = 35 WHERE Name = 'John Doe'", con))
                {
                    cmd.ExecuteNonQuery();
                }

                // DELETE operation
                using (var cmd = new SQLiteCommand("DELETE FROM Users WHERE Age = 35", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
