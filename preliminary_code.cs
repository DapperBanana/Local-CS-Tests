using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, long> memo = new Dictionary<int, long>();

    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        if (memo.ContainsKey(n))
            return memo[n];

        long result = Fibonacci(n - 1) + Fibonacci(n - 2);
        memo[n] = result;
        return result;
    }

    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"The {n}th Fibonacci number is: {Fibonacci(n)}");
    }
}