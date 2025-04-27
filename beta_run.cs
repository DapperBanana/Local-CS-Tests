
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length;

        Console.Write("Enter the length of the password: ");
        while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter the length of the password: ");
        }

        Console.WriteLine("Generated password: " + GenerateRandomPassword(length));
    }

    static string GenerateRandomPassword(int length)
    {
        const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder password = new StringBuilder();

        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rand.Next(validChars.Length);
            password.Append(validChars[index]);
        }

        return password.ToString();
    }
}
