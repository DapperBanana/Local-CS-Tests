using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the desired password length:");
        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
        {
            string password = GenerateRandomPassword(length);
            Console.WriteLine($"Generated Password: {password}");
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }

    static string GenerateRandomPassword(int length)
    {
        const string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;:,.<>?";
        var random = new Random();
        char[] passwordChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            passwordChars[i] = charset[random.Next(charset.Length)];
        }

        return new string(passwordChars);
    }
}