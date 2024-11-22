
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The input is not a valid palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        string cleanInput = RemoveSpecialCharacters(input.ToLower());
        int length = cleanInput.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (cleanInput[i] != cleanInput[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static string RemoveSpecialCharacters(string input)
    {
        return string.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
    }
}
