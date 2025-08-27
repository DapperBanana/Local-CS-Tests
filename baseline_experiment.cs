
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
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

    static bool IsPalindrome(string input)
    {
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
