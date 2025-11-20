
using System;

class PalindromeChecker
{
    static bool IsPalindrome(int num)
    {
        int originalNum = num;
        int reverseNum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reverseNum = reverseNum * 10 + digit;
            num = num / 10;
        }

        return originalNum == reverseNum;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a palindrome: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPalindrome(num))
        {
            Console.WriteLine($"{num} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{num} is not a palindrome.");
        }
    }
}
