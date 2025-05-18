
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string to be reversed: ");
        string input = Console.ReadLine();
        
        string reversed = ReverseString(input);
        
        Console.WriteLine($"Reversed string: {reversed}");
    }
    
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
