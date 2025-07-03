
using System;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=sqlite_database.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Create table
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Students (Id INTEGER PRIMARY KEY, Name TEXT, Grade INTEGER)";
            SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);

            connection.Open();
            createTableCommand.ExecuteNonQuery();

            // Insert data
            string insertQuery = "INSERT INTO Students (Name, Grade) VALUES ('John Doe', 95)";
            SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();

            // Read data
            string selectQuery = "SELECT * FROM Students";
            SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Grade: {reader["Grade"]}");
            }

            // Update data
            string updateQuery = "UPDATE Students SET Grade = 90 WHERE Name = 'John Doe'";
            SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection);
            updateCommand.ExecuteNonQuery();

            // Delete data
            string deleteQuery = "DELETE FROM Students WHERE Name = 'John Doe'";
            SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection);
            deleteCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}
