
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} is {factorial}");
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
