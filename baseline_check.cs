
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the password: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Random Password: " + GenerateRandomPassword(length));
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";

        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }
}
