
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
        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        return number % sum == 0;
    }
}
