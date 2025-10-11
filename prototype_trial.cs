
using System;

class FactorialCalculator
{
    static int CalculateFactorial(int n)
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

    static void Main()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int factorial = CalculateFactorial(number);

        Console.WriteLine("The factorial of {0} is {1}", number, factorial);
    }
}
