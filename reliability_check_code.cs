
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=MyDatabase.db;Version=3;";
        
        // Create table
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT, Age INT)";
            var command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }
        
        // Insert data
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertDataQuery = "INSERT INTO Users (Name, Age) VALUES (@name, @age)";
            var command = new SQLiteCommand(insertDataQuery, connection);
            command.Parameters.AddWithValue("@name", "John Doe");
            command.Parameters.AddWithValue("@age", 30);

            command.ExecuteNonQuery();
        }
        
        // Read data
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string readDataQuery = "SELECT * FROM Users";
            var command = new SQLiteCommand(readDataQuery, connection);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
            }
        }

        // Update data
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string updateDataQuery = "UPDATE Users SET Age = @newAge WHERE Name = @name";
            var command = new SQLiteCommand(updateDataQuery, connection);
            command.Parameters.AddWithValue("@newAge", 35);
            command.Parameters.AddWithValue("@name", "John Doe");

            command.ExecuteNonQuery();
        }

        // Delete data
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteDataQuery = "DELETE FROM Users WHERE Name = @name";
            var command = new SQLiteCommand(deleteDataQuery, connection);
            command.Parameters.AddWithValue("@name", "John Doe");

            command.ExecuteNonQuery();
        }
    }
}
