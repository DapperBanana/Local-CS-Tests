
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
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

    static bool IsPalindrome(string input)
    {
        input = input.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");

        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            if (input[start] != input[end])
            {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
}
