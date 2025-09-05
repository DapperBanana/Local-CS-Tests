
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a valid palindrome sentence:");
        string input = Console.ReadLine();

        // Remove all non-alphanumeric characters from the input string
        string sanitizedInput = new string(Array.FindAll(input.ToLower().ToCharArray(), c => char.IsLetterOrDigit(c)));

        // Check if the sanitized input is a palindrome
        bool isPalindrome = IsPalindrome(sanitizedInput);

        if (isPalindrome)
        {
            Console.WriteLine("The input string is a valid palindrome sentence.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid palindrome sentence.");
        }
    }

    static bool IsPalindrome(string input)
    {
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
