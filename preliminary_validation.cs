
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to check if it is a palindrome:");
        string userInput = Console.ReadLine();

        if (IsPalindrome(userInput))
        {
            Console.WriteLine("The sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The sentence is not a valid palindrome.");
        }
    }

    static bool IsPalindrome(string sentence)
    {
        string cleanSentence = CleanString(sentence);
        string reversedSentence = ReverseString(cleanSentence);

        return cleanSentence.Equals(reversedSentence, StringComparison.OrdinalIgnoreCase);
    }

    static string CleanString(string input)
    {
        string cleanString = input.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");
        return cleanString;
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
