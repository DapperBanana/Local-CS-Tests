
using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        input = input.ToLower().Replace(" ", "").Replace(".", "").Replace(",", ""); // Convert input to lowercase and remove spaces, periods, and commas
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);

        return input.Equals(reversedInput);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The given string is a valid palindrome sentence.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid palindrome sentence.");
        }
    }
}
