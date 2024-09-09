
using System;

class Program
{
    static void Main()
    {
        int length = 8; // Length of the password
        string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*"; // Characters allowed in the password

        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = allowedChars[random.Next(0, allowedChars.Length)];
        }

        string randomPassword = new string(password);
        Console.WriteLine("Random Password: " + randomPassword);
    }
}
