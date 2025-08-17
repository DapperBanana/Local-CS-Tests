
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (CheckPerfectDigitalInvariant(number))
        {
            Console.WriteLine("The number is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine("The number is not a perfect digital invariant.");
        }
    }

    static bool CheckPerfectDigitalInvariant(int num)
    {
        int sum = 0;
        int product = 1;

        while (num > 0)
        {
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num /= 10;
        }

        return sum == product;
    }
}
