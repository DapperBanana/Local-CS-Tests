
using System;

class Program
{
    static void Main()
    {
        int limit = 4000000;
        long sum = 0;

        long a = 1;
        long b = 2;

        while (a <= limit)
        {
            if (a % 2 == 0)
            {
                sum += a;
            }

            long next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine("The sum of all even Fibonacci numbers up to " + limit + " is: " + sum);
    }
}
