
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the password: ");
        int passwordLength = int.Parse(Console.ReadLine());

        string password = GenerateRandomPassword(passwordLength);
        Console.WriteLine("Generated Password: " + password);
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        var password = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }
}
