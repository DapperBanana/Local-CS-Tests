
using System;
using System.Text;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        int length = 8; // Set the length of the password
        
        string randomPassword = GenerateRandomPassword(length);
        Console.WriteLine($"Random password: {randomPassword}");
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }
}
