
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long result = Factorial(num);
        
        Console.WriteLine($"Factorial of {num} is: {result}");
    }

    static long Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
