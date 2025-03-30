
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=database.db;Version=3;";
        
        // Create a new SQLite database file
        SQLiteConnection.CreateFile("database.db");
        
        // Establish a connection to the database
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Create a table
            string createTableQuery = "CREATE TABLE users (id INTEGER PRIMARY KEY, name TEXT, email TEXT)";
            using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Insert a new record
            string insertQuery = "INSERT INTO users (name, email) VALUES ('John Doe', 'john.doe@example.com')";
            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Read records
            string selectQuery = "SELECT * FROM users";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Email: {reader.GetString(2)}");
                    }
                }
            }

            // Update a record
            string updateQuery = "UPDATE users SET email = 'updated.email@example.com' WHERE id = 1";
            using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Delete a record
            string deleteQuery = "DELETE FROM users WHERE id = 1";
            using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
