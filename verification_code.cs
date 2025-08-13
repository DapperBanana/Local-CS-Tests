
using System;

class Program
{
    static void Main()
    {
        string password = GenerateRandomPassword(8); // Generate a random alphanumeric password of length 8
        Console.WriteLine("Generated Password: " + password);
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] password = new char[length];
        
        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }
}
