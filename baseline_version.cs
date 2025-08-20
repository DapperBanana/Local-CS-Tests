
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to be reversed:");
        string input = Console.ReadLine();
        
        string reversedString = ReverseString(input);
        
        Console.WriteLine("Reversed string: " + reversedString);
    }
    
    static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
