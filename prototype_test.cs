
using System;

class Program
{
    static void Main()
    {
        // Input string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Reversing the string
        string reversedString = ReverseString(input);

        Console.WriteLine("Reversed String: " + reversedString);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
