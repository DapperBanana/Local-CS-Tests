
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectDigitalInvariant(number))
        {
            Console.WriteLine($"The number {number} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"The number {number} is not a perfect digital invariant.");
        }
    }

    static bool IsPerfectDigitalInvariant(int number)
    {
        int sum = 0;
        int product = 1;
        int originalNumber = number;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        return (sum * product) == originalNumber;
    }
}
