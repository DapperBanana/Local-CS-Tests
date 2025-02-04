
using System;

class Program
{
    static void Main()
    {
        // Input string
        string input = "Hello, World!";
        
        // Output string
        string reversedInput = ReverseString(input);
        
        Console.WriteLine($"Original string: {input}");
        Console.WriteLine($"Reversed string: {reversedInput}");
    }
    
    // Function to reverse a string
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
