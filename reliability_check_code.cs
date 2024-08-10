
using System;
using System.Data.SQLite;

namespace CRUDSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            
            // Create a new SQLite database file if it doesn't exist
            SQLiteConnection.CreateFile("mydatabase.db");

            // Create a new table
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Insert data
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO MyTable (Name) VALUES (@Name)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", "John Doe");
                    command.ExecuteNonQuery();
                }
            }

            // Read data
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM MyTable";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}");
                        }
                    }
                }
            }

            // Update data
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE MyTable SET Name = @NewName WHERE Name = @OldName";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewName", "Jane Doe");
                    command.Parameters.AddWithValue("@OldName", "John Doe");
                    command.ExecuteNonQuery();
                }
            }

            // Delete data
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM MyTable WHERE Name = @Name";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", "Jane Doe");
                    command.ExecuteNonQuery();
                }
            }

            // Display updated data
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM MyTable";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}");
                        }
                    }
                }
            }
        }
    }
}
