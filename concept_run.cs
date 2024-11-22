
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to check if it is a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The sentence is not a palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        input = input.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
