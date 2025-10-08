
using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to check if it is a valid palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The input sentence is not a valid palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        // remove all non-alphanumeric characters
        string cleanInput = new string(Array.FindAll(input.ToLower().ToCharArray(), char.IsLetterOrDigit));

        // compare the cleanInput with its reverse
        for (int i = 0; i < cleanInput.Length / 2; i++)
        {
            if (cleanInput[i] != cleanInput[cleanInput.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
