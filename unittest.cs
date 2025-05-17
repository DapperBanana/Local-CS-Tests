
using System;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MyDatabase.db";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create table
                using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)", connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert data
                using (var command = new SQLiteCommand("INSERT INTO Users (Name) VALUES (@name)", connection))
                {
                    command.Parameters.AddWithValue("@name", "John Doe");
                    command.ExecuteNonQuery();
                }

                // Read data
                using (var command = new SQLiteCommand("SELECT * FROM Users", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                        }
                    }
                }

                // Update data
                using (var command = new SQLiteCommand("UPDATE Users SET Name = @newName WHERE Name = 'John Doe'", connection))
                {
                    command.Parameters.AddWithValue("@newName", "Jane Smith");
                    command.ExecuteNonQuery();
                }

                // Delete data
                using (var command = new SQLiteCommand("DELETE FROM Users WHERE Name = 'Jane Smith'", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
