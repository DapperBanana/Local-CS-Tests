
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the password: ");
        int length = Convert.ToInt32(Console.ReadLine());

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
