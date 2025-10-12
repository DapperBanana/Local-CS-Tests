
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome sentence:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input string is a palindrome sentence.");
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome sentence.");
        }
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower();
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (!char.IsLetter(str[i]))
            {
                i++;
            }
            else if (!char.IsLetter(str[j]))
            {
                j--;
            }
            else if (str[i] != str[j])
            {
                return false;
            }
            else
            {
                i++;
                j--;
            }
        }

        return true;
    }
}
