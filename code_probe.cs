
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 8; // Change the password length as needed
        string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            password.Append(allowedChars[random.Next(0, allowedChars.Length)]);
        }

        Console.WriteLine("Random alphanumeric password: " + password.ToString());
    }
}
