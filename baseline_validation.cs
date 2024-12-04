
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("The input string is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        input = input.ToLower();
        input = RemovePunctuation(input);

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    static string RemovePunctuation(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                result += c;
            }
        }
        return result;
    }
}
