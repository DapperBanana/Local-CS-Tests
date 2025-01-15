
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
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
        input = input.ToLower().Replace(" ", "");

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
