
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the password: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Generated Password: " + GenerateRandomPassword(length));
    }

    static string GenerateRandomPassword(int length)
    {
        const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";

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
