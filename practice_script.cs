
using System;

class Program
{
    static void Main()
    {
        // Input string
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine();

        // Call ReverseString method
        string reversedString = ReverseString(input);

        // Output reversed string
        Console.WriteLine("Reversed string: " + reversedString);
    }

    // Method to reverse a string
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
