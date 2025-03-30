
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPerfectDigitalInvariant(num))
        {
            Console.WriteLine($"{num} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"{num} is not a perfect digital invariant.");
        }
    }

    static bool IsPerfectDigitalInvariant(int num)
    {
        int sum = 0;
        int product = 1;

        int temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        return sum == product;
    }
}
