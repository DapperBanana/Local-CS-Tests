
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The sentence is not a valid palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        input = input.ToLower(); // Convert input to lowercase

        // Remove all non-alphanumeric characters from the input
        string cleanInput = "";
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanInput += c;
            }
        }

        // Check if the clean input is a palindrome
        int left = 0;
        int right = cleanInput.Length - 1;

        while (left < right)
        {
            if (cleanInput[left] != cleanInput[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
