
using System;
using System.Data;
using System.Data.SQLite;

class Program
{
    static string connectionString = "Data Source=database.db;Version=3;";
    
    static void Main()
    {
        CreateTable();
        InsertData();
        ReadData();
        UpdateData();
        ReadData();
        DeleteData();
        ReadData();
    }

    static void CreateTable()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string query = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }

    static void InsertData()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string query = "INSERT INTO MyTable (Name) VALUES ('Alice')";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }

    static void ReadData()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM MyTable";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row["Id"] + " " + row["Name"]);
            }
        }
    }

    static void UpdateData()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string query = "UPDATE MyTable SET Name = 'Bob' WHERE Id = 1";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }

    static void DeleteData()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            
            string query = "DELETE FROM MyTable WHERE Id = 1";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
