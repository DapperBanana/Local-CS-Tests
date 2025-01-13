
using System;

class Program
{
    static void Main()
    {
        // Get input string from user
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine();
        
        // Call the ReverseString function and display the reversed string
        string reversedString = ReverseString(input);
        Console.WriteLine($"Reversed string: {reversedString}");
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
