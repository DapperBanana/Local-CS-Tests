
using System;

class Program
{
    static void Main()
    {
        int passwordLength;
        
        Console.Write("Enter the desired length for the password: ");
        while (!int.TryParse(Console.ReadLine(), out passwordLength) || passwordLength <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }

        string password = GeneratePassword(passwordLength);
        
        Console.WriteLine($"Randomly generated password of length {passwordLength}: {password}");
    }
    
    static string GeneratePassword(int length)
    {
        string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=";
        char[] password = new char[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            password[i] = validChars[random.Next(validChars.Length)];
        }

        return new string(password);
    }
}
