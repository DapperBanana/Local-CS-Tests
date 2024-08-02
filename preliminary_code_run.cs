
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The given string is a valid palindrome sentence.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid palindrome sentence.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Remove spaces and punctuation from the string
        string cleanStr = "";
        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanStr += char.ToLower(c);
            }
        }

        // Check if the clean string is a palindrome
        int left = 0;
        int right = cleanStr.Length - 1;
        while (left < right)
        {
            if (cleanStr[left] != cleanStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
