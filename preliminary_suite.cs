
using System;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MyDatabase.db;Version=3;";
            
            // Create
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Employees (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
                
                string insertQuery = "INSERT INTO Employees (Name, Age) VALUES ('John Doe', 30)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            
            // Read
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                string selectQuery = "SELECT * FROM Employees";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                        }
                    }
                }
            }
            
            // Update
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                string updateQuery = "UPDATE Employees SET Age = 35 WHERE Name = 'John Doe'";
                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            
            // Delete
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                string deleteQuery = "DELETE FROM Employees WHERE Name = 'John Doe'";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

