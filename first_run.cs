
using System;
using System.Data;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MyDatabase.db";
    
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
    
                // Create a table
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
    
                // Insert data into the table
                string insertQuery = "INSERT INTO Users (Name, Age) VALUES (@Name, @Age)";
                SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Name", "John Doe");
                insertCommand.Parameters.AddWithValue("@Age", 30);
                insertCommand.ExecuteNonQuery();
    
                // Read data from the table
                string selectQuery = "SELECT * FROM Users";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
    
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Age: {row["Age"]}");
                }
    
                // Update data in the table
                string updateQuery = "UPDATE Users SET Age = @Age WHERE Name = @Name";
                SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@Name", "John Doe");
                updateCommand.Parameters.AddWithValue("@Age", 32);
                updateCommand.ExecuteNonQuery();
    
                // Delete data from the table
                string deleteQuery = "DELETE FROM Users WHERE Name = @Name";
                SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@Name", "John Doe");
                deleteCommand.ExecuteNonQuery();
    
                connection.Close();
            }
        }
    }
}
