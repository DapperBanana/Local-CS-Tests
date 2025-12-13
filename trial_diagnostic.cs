using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        if (long.TryParse(Console.ReadLine(), out long number))
        {
            bool isPDI = IsPerfectDigitalInvariant(number);
            Console.WriteLine($"{number} is {(isPDI ? "" : "not ")}a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static bool IsPerfectDigitalInvariant(long number)
    {
        if (number < 0)
            return false;

        long sum = 0;
        long temp = number;

        while (temp > 0)
        {
            int digit = (int)(temp % 10);
            sum += (long)Math.Pow(digit, digit);
            temp /= 10;
        }

        return sum == number;
    }
}