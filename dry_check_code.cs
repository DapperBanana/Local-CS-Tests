
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string to check if it's a palindrome: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input is a palindrome.");
        }
        else
        {
            Console.WriteLine("The input is not a palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        int length = input.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
