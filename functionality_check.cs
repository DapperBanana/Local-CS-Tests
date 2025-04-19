
using System;
using System.Text;

class Program
{
    static void Main()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Characters to choose from
        const int passwordLength = 10; // Length of the password

        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < passwordLength; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        Console.WriteLine("Generated Password: " + password.ToString());
    }
}
