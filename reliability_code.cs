
using System;

class Program
{
    static bool IsPalindrome(string input)
    {
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
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
}
