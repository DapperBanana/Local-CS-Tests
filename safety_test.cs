
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Random Alphanumeric Password Generator");
        Console.WriteLine("--------------------------------------");
        
        // Generate a random alphanumeric password
        string password = GeneratePassword(8); // Change the number in the parameter to change the length of the password

        Console.WriteLine("Generated Password: " + password);
    }

    static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] password = new char[length];
        
        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }
        
        return new string(password);
    }
}
