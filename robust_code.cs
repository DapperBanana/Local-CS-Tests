
using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to check if it's a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The entered sentence is a palindrome.");
        }
        else
        {
            Console.WriteLine("The entered sentence is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Remove all non-alphanumeric characters and convert the string to lowercase
        string cleanStr = new string(str.ToLower().ToCharArray().Where(c => Char.IsLetterOrDigit(c)).ToArray());

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
