
using System;

class Program
{
    static void Main()
    {
        // Define the characters that can be used in the password
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_";

        // Get the desired length of the password from the user
        Console.Write("Enter the desired length of the password: ");
        int passwordLength = Convert.ToInt32(Console.ReadLine());

        // Generate a random password
        Random random = new Random();
        char[] password = new char[passwordLength];
        for (int i = 0; i < passwordLength; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        // Display the generated password
        Console.WriteLine("Generated Password: " + new string(password));
    }
}
