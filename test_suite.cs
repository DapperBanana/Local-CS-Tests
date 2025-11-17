
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 10; // Length of the password
        string password = GenerateRandomPassword(length);
        
        Console.WriteLine("Random alphanumeric password: " + password);
    }

    static string GenerateRandomPassword(int length)
    {
        // Define the characters allowed in the password
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        
        Random random = new Random();
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            sb.Append(chars[index]);
        }
        
        return sb.ToString();
    }
}
