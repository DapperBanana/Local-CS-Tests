
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if(isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while(i < j)
        {
            if(str[i] != str[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
