
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 10; // Change the length of the password as needed

        string password = GenerateRandomPassword(length);

        Console.WriteLine("Generated Password: " + password);
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }
}
