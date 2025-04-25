
using System;
using System.Data.SQLite;

namespace CRUDSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MyDatabase.db;Version=3;";
            
            // Create a new SQLite database file
            SQLiteConnection.CreateFile("MyDatabase.db");

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create a table
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                SQLiteCommand createTableCmd = new SQLiteCommand(createTableQuery, connection);
                createTableCmd.ExecuteNonQuery();

                // Insert data into table
                string insertQuery = "INSERT INTO Users (Name, Age) VALUES ('John Doe', 30)";
                SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection);
                insertCmd.ExecuteNonQuery();

                // Read data from table
                string selectQuery = "SELECT * FROM Users";
                SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, connection);
                SQLiteDataReader reader = selectCmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                }

                // Update data in table
                string updateQuery = "UPDATE Users SET Age = 35 WHERE Name = 'John Doe'";
                SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, connection);
                updateCmd.ExecuteNonQuery();

                // Delete data from table
                string deleteQuery = "DELETE FROM Users WHERE Name = 'John Doe'";
                SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, connection);
                deleteCmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
