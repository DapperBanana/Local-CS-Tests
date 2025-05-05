
using System;

class PalindromeChecker
{
    static bool IsPalindrome(string str)
    {
        str = str.ToLower();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(str[left]))
            {
                left++;
            }
            else if (!char.IsLetterOrDigit(str[right]))
            {
                right--;
            }
            else if (str[left] != str[right])
            {
                return false;
            }
            else
            {
                left++;
                right--;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter a sentence to check if it's a palindrome:");
        string sentence = Console.ReadLine();

        if (IsPalindrome(sentence))
        {
            Console.WriteLine("The sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The sentence is not a palindrome.");
        }
    }
}
