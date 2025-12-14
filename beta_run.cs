using System;
using System.Text.RegularExpressions;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        
        if (IsPalindromeSentence(input))
        {
            Console.WriteLine("The sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The sentence is not a valid palindrome.");
        }
    }

    static bool IsPalindromeSentence(string sentence)
    {
        // Remove non-alphanumeric characters and convert to lowercase
        string sanitized = Regex.Replace(sentence, "[^a-zA-Z0-9]", "").ToLower();
        // Check if the sanitized string is a palindrome
        return sanitized == ReverseString(sanitized);
    }

    static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}