
using System;

class Fibonacci
{
    static int[] memo;

    static int FibonacciMemo(int n)
    {
        if (memo[n] != -1)
        {
            return memo[n];
        }

        if (n <= 1)
        {
            memo[n] = n;
        }
        else
        {
            memo[n] = FibonacciMemo(n - 1) + FibonacciMemo(n - 2);
        }

        return memo[n];
    }

    static void Main()
    {
        int n = 10;
        memo = new int[n + 1];
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = -1;
        }

        Console.WriteLine($"The {n}th term of the Fibonacci sequence is {FibonacciMemo(n)}");
    }
}
