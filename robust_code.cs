
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Define the characters that can be used in the password
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        // Create a random number generator
        Random random = new Random();

        // Set the length of the password
        int length = 10;

        // Generate random alphanumeric password
        StringBuilder password = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }
        
        Console.WriteLine("Generated random alphanumeric password: " + password);
    }
}
