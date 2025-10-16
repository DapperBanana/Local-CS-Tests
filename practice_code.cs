
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a valid palindrome sentence:");
        string input = Console.ReadLine();

        string reversedInput = ReverseString(input);

        if (IsPalindrome(input, reversedInput))
        {
            Console.WriteLine("The given string is a valid palindrome sentence.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid palindrome sentence.");
        }
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static bool IsPalindrome(string original, string reversed)
    {
        return original.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
