
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
        str = str.ToLower(); // convert input to lowercase for case-insensitive comparison
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
