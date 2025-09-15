
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 10; // length of the password
        string password = GeneratePassword(length);
        
        Console.WriteLine("Random alphanumeric password: " + password);
    }

    static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder password = new StringBuilder();
        
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }
        
        return password.ToString();
    }
}
