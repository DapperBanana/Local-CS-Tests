
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=mydatabase.db;Version=3;";

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Create Table
            using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
            }

            // Insert Data
            using (var command = new SQLiteCommand("INSERT INTO Users (Name, Age) VALUES ('John', 30)", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
            }

            // Read Data
            using (var command = new SQLiteCommand("SELECT * FROM Users", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id: " + reader["Id"] + ", Name: " + reader["Name"] + ", Age: " + reader["Age"]);
                    }
                }
            }

            // Update Data
            using (var command = new SQLiteCommand("UPDATE Users SET Age=35 WHERE Name='John'", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Data updated successfully");
            }

            // Delete Data
            using (var command = new SQLiteCommand("DELETE FROM Users WHERE Name='John'", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Data deleted successfully");
            }

            connection.Close();
        }
    }
}
