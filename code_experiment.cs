
using System;

class Program
{
    static void Main()
    {
        int limit;
        Console.Write("Enter the limit for Fibonacci numbers: ");
        limit = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int a = 0;
        int b = 1;
        int temp;

        while (b <= limit)
        {
            if (b % 2 == 0)
            {
                sum += b;
            }
            temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"The sum of all even Fibonacci numbers up to {limit} is: {sum}");
    }
}
