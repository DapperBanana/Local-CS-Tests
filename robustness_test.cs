
using System;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=crud.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // CREATE
                using (SQLiteCommand createCommand = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT, Age INTEGER)", connection))
                {
                    createCommand.ExecuteNonQuery();
                }

                // INSERT
                using (SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Users (Name, Age) VALUES ('John Doe', 30)", connection))
                {
                    insertCommand.ExecuteNonQuery();
                }

                // READ
                using (SQLiteCommand readCommand = new SQLiteCommand("SELECT * FROM Users", connection))
                {
                    using (SQLiteDataReader reader = readCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                        }
                    }
                }

                // UPDATE
                using (SQLiteCommand updateCommand = new SQLiteCommand("UPDATE Users SET Age = 31 WHERE Name = 'John Doe'", connection))
                {
                    updateCommand.ExecuteNonQuery();
                }

                // READ after update
                using (SQLiteCommand readCommand = new SQLiteCommand("SELECT * FROM Users", connection))
                {
                    using (SQLiteDataReader reader = readCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                        }
                    }
                }

                // DELETE
                using (SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM Users WHERE Name = 'John Doe'", connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                // READ after delete
                using (SQLiteCommand readCommand = new SQLiteCommand("SELECT * FROM Users", connection))
                {
                    using (SQLiteDataReader reader = readCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                        }
                    }
                }
            }
        }
    }
}
