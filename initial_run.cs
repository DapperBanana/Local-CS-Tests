
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        const int passwordLength = 10;

        StringBuilder password = new StringBuilder();
        for (int i = 0; i < passwordLength; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        Console.WriteLine("Random alphanumeric password: " + password.ToString());
    }
}
