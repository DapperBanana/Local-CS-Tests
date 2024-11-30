
using System;

class Program
{
    static void Main()
    {
        string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rng = new Random();
        int length = 12;
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = allowedChars[rng.Next(0, allowedChars.Length)];
        }

        string generatedPassword = new string(password);
        Console.WriteLine("Generated Password: " + generatedPassword);
    }
}
