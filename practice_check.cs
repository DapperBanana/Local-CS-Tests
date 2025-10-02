
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectDigitalInvariant(number))
        {
            Console.WriteLine($"{number} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect digital invariant.");
        }
    }

    static bool IsPerfectDigitalInvariant(int number)
    {
        int originalNumber = number;
        int reversedNumber = ReverseNumber(number);
        int sum = originalNumber + reversedNumber;

        return sum == originalNumber;
    }

    static int ReverseNumber(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            reversed = reversed * 10 + remainder;
            number = number / 10;
        }
        return reversed;
    }
}
