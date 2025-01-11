
using System;

class Program
{
    static void Main()
    {
        int length = 10; // specify the length of the password
        string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = allowedChars[random.Next(0, allowedChars.Length)];
        }

        string generatedPassword = new string(password);
        Console.WriteLine("Generated Password: " + generatedPassword);
    }
}
