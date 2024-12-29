
using System;

class Program
{
    static void Main()
    {
        int num;
        Console.WriteLine("Enter a number to calculate its factorial:");
        num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(num);
        Console.WriteLine($"Factorial of {num} is {factorial}");
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}
