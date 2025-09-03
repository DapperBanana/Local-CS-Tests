
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 10; // Length of the password
        string password = GenerateRandomPassword(length);
        Console.WriteLine("Random Password: " + password);
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        var password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }
}
