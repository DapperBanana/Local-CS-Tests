
using System;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=database.db;Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create table
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert data
                string insertQuery = "INSERT INTO Users (Name, Age) VALUES ('John Doe', 30)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Read data
                string selectQuery = "SELECT * FROM Users";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Id"]}, {reader["Name"]}, {reader["Age"]}");
                        }
                    }
                }

                // Update data
                string updateQuery = "UPDATE Users SET Age = 35 WHERE Name = 'John Doe'";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Delete data
                string deleteQuery = "DELETE FROM Users WHERE Name = 'John Doe'";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
