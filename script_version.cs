
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the limit for Fibonacci numbers: ");
        int limit = int.Parse(Console.ReadLine());

        int sum = CalculateEvenFibonacciSum(limit);
        Console.WriteLine($"The sum of all even Fibonacci numbers up to {limit} is: {sum}");
    }

    static int CalculateEvenFibonacciSum(int limit)
    {
        int a = 1, b = 1, c = 0;
        int sum = 0;

        while (c <= limit)
        {
            c = a + b;
            a = b;
            b = c;

            if (c % 2 == 0 && c <= limit)
            {
                sum += c;
            }
        }

        return sum;
    }
}
