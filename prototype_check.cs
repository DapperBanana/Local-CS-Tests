
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        // Set the connection string
        string connectionString = "Data Source=database.db";

        // Create a new SQLite connection
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Create a new SQLite command
            using (SQLiteCommand command = connection.CreateCommand())
            {
                // Create a table
                command.CommandText = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                command.ExecuteNonQuery();

                // Insert data
                command.CommandText = "INSERT INTO Users (Name, Age) VALUES ('Alice', 30)";
                command.ExecuteNonQuery();

                // Update data
                command.CommandText = "UPDATE Users SET Age = 31 WHERE Name = 'Alice'";
                command.ExecuteNonQuery();

                // Read data
                command.CommandText = "SELECT * FROM Users";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                    }
                }

                // Delete data
                command.CommandText = "DELETE FROM Users WHERE Name = 'Alice'";
                command.ExecuteNonQuery();
            }
        }
    }
}
