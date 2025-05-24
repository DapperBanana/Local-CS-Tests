
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool isPalindrome = CheckPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }

    static bool CheckPalindrome(string input)
    {
        input = input.ToLower().Replace(" ", "");

        int start = 0;
        int end = input.Length - 1;

        while (end > start)
        {
            if (input[start++] != input[end--])
            {
                return false;
            }
        }

        return true;
    }
}
