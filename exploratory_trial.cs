
using System;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MyDatabase.db;Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create table if it does not exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTs Customers (Id INTEGER PRIMARY KEY, Name TEXT, Email TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert data
                string insertQuery = "INSERT INTO Customers (Name, Email) VALUES ('John Doe', 'john.doe@example.com')";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Select data
                string selectQuery = "SELECT * FROM Customers";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Email: {reader["Email"]}");
                        }
                    }
                }

                // Update data
                string updateQuery = "UPDATE Customers SET Email = 'john.doe.updated@example.com' WHERE Name = 'John Doe'";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Delete data
                string deleteQuery = "DELETE FROM Customers WHERE Name = 'John Doe'";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
