
using System;

class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        input = input.ToLower();

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome.");
        }
    }
}
