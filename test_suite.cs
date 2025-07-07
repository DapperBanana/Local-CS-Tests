
using System;
using System.Data.SQLite;

class Program
{
    private const string connectionString = "Data Source=mydatabase.db;Version=3;";

    static void Main()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Create a table
            SQLiteCommand createTableCommand = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)", connection);
            createTableCommand.ExecuteNonQuery();

            // Insert data
            SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Users (Name, Age) VALUES ('Alice', 30)", connection);
            insertCommand.ExecuteNonQuery();

            // Read data
            SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Users", connection);
            using (SQLiteDataReader reader = selectCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                }
            }

            // Update data
            SQLiteCommand updateCommand = new SQLiteCommand("UPDATE Users SET Age = 25 WHERE Name = 'Alice'", connection);
            updateCommand.ExecuteNonQuery();

            // Delete data
            SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM Users WHERE Name = 'Alice'", connection);
            deleteCommand.ExecuteNonQuery();
        }
    }
}
