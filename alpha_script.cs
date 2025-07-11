
using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string cs = "Data Source=crud.db;Version=3;";

        using var con = new SQLiteConnection(cs);
        con.Open();

        using var cmd = new SQLiteCommand(con);

        cmd.CommandText = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT)";
        cmd.ExecuteNonQuery();

        // Insert
        cmd.CommandText = "INSERT INTO Users (Name) VALUES (@name)";
        cmd.Parameters.AddWithValue("@name", "John Doe");
        cmd.ExecuteNonQuery();

        // Update
        cmd.CommandText = "UPDATE Users SET Name = @name WHERE Id = 1";
        cmd.ExecuteNonQuery();

        // Select
        cmd.CommandText = "SELECT * FROM Users";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader.GetInt32(0)}, Name: {reader.GetString(1)}");
        }

        // Delete
        cmd.CommandText = "DELETE FROM Users WHERE Id = 1";
        cmd.ExecuteNonQuery();
    }
}
