
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
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

    static bool IsPalindrome(string str)
    {
        char[] cleanedArray = CleanString(str).ToCharArray();
        Array.Reverse(cleanedArray);
        string reversedString = new string(cleanedArray);

        return cleanedArray.Length > 0 && cleanedArray.Equals(reversedString);
    }

    static string CleanString(string str)
    {
        string cleanedString = "";
        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanedString += char.ToLower(c);
            }
        }
        return cleanedString;
    }
}
