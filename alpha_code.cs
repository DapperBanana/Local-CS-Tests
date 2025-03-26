
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=database.db;Version=3;";
        
        using (var connection = new SQLiteConnection(connectionString))
        {
            // Create table
            connection.Open();
            using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT, Age INTEGER)", connection))
            {
                command.ExecuteNonQuery();
            }

            // Insert data
            using (var command = new SQLiteCommand("INSERT INTO Users (Name, Age) VALUES ('Alice', 25)", connection))
            {
                command.ExecuteNonQuery();
            }

            // Read data
            using (var command = new SQLiteCommand("SELECT * FROM Users", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                    }
                }
            }

            // Update data
            using (var command = new SQLiteCommand("UPDATE Users SET Age = 30 WHERE Name = 'Alice'", connection))
            {
                command.ExecuteNonQuery();
            }

            // Delete data
            using (var command = new SQLiteCommand("DELETE FROM Users WHERE Name = 'Alice'", connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
