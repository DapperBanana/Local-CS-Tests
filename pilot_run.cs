
using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string: ");
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

    static bool IsPalindrome(string str)
    {
        str = str.ToLower().Replace(" ", ""); // Convert to lowercase and remove spaces

        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
