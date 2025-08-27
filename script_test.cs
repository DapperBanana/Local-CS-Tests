
using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        int i = 0;
        int j = input.Length - 1;

        while (i < j)
        {
            if (input[i] != input[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }

    static void Main()
    {
        string input = "racecar";

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
