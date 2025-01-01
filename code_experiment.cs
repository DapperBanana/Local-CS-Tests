
using System;
using System.Data.SQLite;

class Program {
    static void Main() {
        string connectionString = "Data Source=database.db;Version=3;";

        using (var connection = new SQLiteConnection(connectionString)) {
            connection.Open();

            // Create table
            var createTableCmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Data (Id INTEGER PRIMARY KEY, Name TEXT)", connection);
            createTableCmd.ExecuteNonQuery();

            // Insert data
            var insertCmd = new SQLiteCommand("INSERT INTO Data (Name) VALUES ('John Doe')", connection);
            insertCmd.ExecuteNonQuery();

            // Read data
            var selectCmd = new SQLiteCommand("SELECT * FROM Data", connection);
            using (var reader = selectCmd.ExecuteReader()) {
                while (reader.Read()) {
                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                }
            }

            // Update data
            var updateCmd = new SQLiteCommand("UPDATE Data SET Name = 'Jane Doe' WHERE Id = 1", connection);
            updateCmd.ExecuteNonQuery();

            // Delete data
            var deleteCmd = new SQLiteCommand("DELETE FROM Data WHERE Id = 1", connection);
            deleteCmd.ExecuteNonQuery();

            // Close connection
            connection.Close();
        }
    }
}
