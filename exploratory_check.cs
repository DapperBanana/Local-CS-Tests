
using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        input = input.ToLower(); // Convert input to lowercase for case-insensitive comparison

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

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"The string '{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"The string '{input}' is not a palindrome.");
        }
    }
}
