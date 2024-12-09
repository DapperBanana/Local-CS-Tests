
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Set the length of the password
        int length = 12;

        // Generate a random alphanumeric password
        string password = GenerateRandomPassword(length);

        Console.WriteLine($"Random Password: {password}");
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        StringBuilder sb = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            sb.Append(chars[index]);
        }

        return sb.ToString();
    }
}
