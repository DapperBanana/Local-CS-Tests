
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Set the length of the password
        int length = 8;
        
        // Generate a random alphanumeric password
        string password = GeneratePassword(length);
        
        // Print the generated password
        Console.WriteLine($"Random password: {password}");
    }
    
    static string GeneratePassword(int length)
    {
        const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            password.Append(validChars[random.Next(validChars.Length)]);
        }

        return password.ToString();
    }
}
