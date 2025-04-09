
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=test.db;Version=3;";
        
        // Create a new SQLite database file
        SQLiteConnection.CreateFile("test.db");
        
        // Create a new table
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string sql = "CREATE TABLE Customers (Id INTEGER PRIMARY KEY, Name TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        
        // Insert new record
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string sql = "INSERT INTO Customers (Name) VALUES ('Alice')";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        
        // Read records
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM Customers";
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, Name: {1}", reader["Id"], reader["Name"]);
                }
            }
        }
        
        // Update record
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string sql = "UPDATE Customers SET Name = 'Bob' WHERE Id = 1";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        
        // Delete record
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string sql = "DELETE FROM Customers WHERE Id = 1";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
