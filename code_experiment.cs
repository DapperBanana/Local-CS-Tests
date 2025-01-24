
using System;

class Program
{
    static void Main()
    {
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        Random rnd = new Random();
        int length = 12; // Change the length of the password here
        
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = characters[rnd.Next(characters.Length)];
        }

        Console.WriteLine("Random alphanumeric password: " + new string(password));
    }
}
