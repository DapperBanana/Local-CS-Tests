
using System;

class Program
{
    static void Main()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random rand = new Random();
        char[] password = new char[8];

        for (int i = 0; i < password.Length; i++)
        {
            password[i] = chars[rand.Next(chars.Length)];
        }

        string generatedPassword = new string(password);
        Console.WriteLine("Generated Password: " + generatedPassword);
    }
}
