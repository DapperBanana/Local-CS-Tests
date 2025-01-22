
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int factorial = CalculateFactorial(number);

        Console.WriteLine("Factorial of {0} is {1}", number, factorial);
    }

    static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
