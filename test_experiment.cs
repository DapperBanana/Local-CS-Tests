
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the password: ");
        int length = int.Parse(Console.ReadLine());

        string password = GeneratePassword(length);
        
        Console.WriteLine("Generated Password: " + password);
    }

    static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
        StringBuilder sb = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(validChars.Length);
            sb.Append(validChars[index]);
        }

        return sb.ToString();
    }
}
