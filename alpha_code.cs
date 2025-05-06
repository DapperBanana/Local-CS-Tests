
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Generated Password: " + GeneratePassword());
    }

    static string GeneratePassword()
    {
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();
        char[] password = new char[8];

        for (int i = 0; i < password.Length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }
}
