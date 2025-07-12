
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 10; // Change this value to set the length of the password
        string password = GenerateRandomPassword(length);

        Console.WriteLine($"Random password: {password}");
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";

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
