
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        
        Console.WriteLine("The factorial of {0} is {1}", number, factorial);
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
