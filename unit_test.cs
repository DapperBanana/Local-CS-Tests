
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the password you want to generate: ");
        int length = Convert.ToInt32(Console.ReadLine());
        
        string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
        Random random = new Random();
        string password = "";
        
        for (int i = 0; i < length; i++)
        {
            password += validChars[random.Next(validChars.Length)];
        }
        
        Console.WriteLine("Generated password: " + password);
    }
}
