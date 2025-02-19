
using System;

class Program
{
    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reverseNumber = reverseNumber * 10 + remainder;
            number = number / 10;
        }

        return originalNumber == reverseNumber;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
    }
}
