
using System;
using System.Text;

class Program
{
    private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

    static void Main()
    {
        Console.WriteLine("Enter the length of the password: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Random password of length {length}: {GenerateRandomPassword(length)}");
    }

    static string GenerateRandomPassword(int length)
    {
        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(characters[random.Next(characters.Length)]);
        }

        return password.ToString();
    }
}
