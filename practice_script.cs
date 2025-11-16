
using System;

class Program
{
    static void Main()
    {
        // Generate a random password with alphanumeric characters
        string password = GenerateRandomPassword(8);
        
        Console.WriteLine("Generated Password: " + password);
    }

    static string GenerateRandomPassword(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }
}
