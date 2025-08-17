
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
    }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        return originalNumber == reversedNumber;
    }
}
