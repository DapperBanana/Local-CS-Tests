
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=test.db;Version=3;";
        
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            
            CreateTable(connection);
            
            InsertData(connection, "John Doe", 30);
            InsertData(connection, "Jane Smith", 25);
            
            ReadData(connection);
            
            UpdateData(connection, 1, "John Smith");
            
            ReadData(connection);
            
            DeleteData(connection, 2);
            
            ReadData(connection);
            
            connection.Close();
        }
    }

    static void CreateTable(SQLiteConnection connection)
    {
        string sql = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, name TEXT, age INTEGER);";
        
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            command.ExecuteNonQuery();
        }
    }

    static void InsertData(SQLiteConnection connection, string name, int age)
    {
        string sql = "INSERT INTO users (name, age) VALUES (@name, @age);";
        
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@age", age);
            command.ExecuteNonQuery();
        }
    }

    static void ReadData(SQLiteConnection connection)
    {
        string sql = "SELECT * FROM users;";
        
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}");
                }
            }
        }
    }

    static void UpdateData(SQLiteConnection connection, int id, string name)
    {
        string sql = "UPDATE users SET name = @name WHERE id = @id;";
        
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }
    }

    static void DeleteData(SQLiteConnection connection, int id)
    {
        string sql = "DELETE FROM users WHERE id = @id;";
        
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}
