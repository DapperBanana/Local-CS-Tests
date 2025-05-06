
using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower();
        // Remove spaces, punctuation, and special characters
        string cleanStr = "";
        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanStr += c;
            }
        }

        // Check if the clean string is a palindrome
        for (int i = 0; i < cleanStr.Length / 2; i++)
        {
            if (cleanStr[i] != cleanStr[cleanStr.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
