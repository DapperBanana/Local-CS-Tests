
using System;

class Program
{
    static void Main()
    {
        int passwordLength = 10; // Change the desired length of the password here

        Console.WriteLine("Generated Password: ");
        Console.WriteLine(GenerateRandomPassword(passwordLength));
    }

    static string GenerateRandomPassword(int length)
    {
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }
}
