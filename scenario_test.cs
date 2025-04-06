
using System;

class Program
{
    static bool IsPalindrome(int num)
    {
        int originalNum = num;
        int reverseNum = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reverseNum = reverseNum * 10 + remainder;
            num = num / 10;
        }

        return originalNum == reverseNum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

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
