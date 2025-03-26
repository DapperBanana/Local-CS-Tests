
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the password:");
        int length = int.Parse(Console.ReadLine());

        string password = GenerateRandomPassword(length);
        Console.WriteLine($"Generated Password: {password}");
    }

    static string GenerateRandomPassword(int length)
    {
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }
}
