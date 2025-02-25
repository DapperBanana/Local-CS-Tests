
using System;
using System.Data.SQLite;

namespace CRUDSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=database.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create table
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                // Insert data
                string insertQuery = "INSERT INTO Users (Name, Age) VALUES ('Alice', 30)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.ExecuteNonQuery();
                }

                // Read data
                string selectQuery = "SELECT * FROM Users";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                        }
                    }
                }

                // Update data
                string updateQuery = "UPDATE Users SET Age = 31 WHERE Name = 'Alice'";
                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.ExecuteNonQuery();
                }

                // Delete data
                string deleteQuery = "DELETE FROM Users WHERE Name = 'Alice'";
                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
