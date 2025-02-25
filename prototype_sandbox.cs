
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the desired length of the password:");
        int length = int.Parse(Console.ReadLine());
        
        string password = GenerateRandomPassword(length);
        
        Console.WriteLine($"Random Password: {password}");
    }
    
    static string GenerateRandomPassword(int length)
    {
        const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
        
        StringBuilder sb = new StringBuilder();
        Random random = new Random();
        
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(0, allowedChars.Length);
            sb.Append(allowedChars[index]);
        }
        
        return sb.ToString();
    }
}
