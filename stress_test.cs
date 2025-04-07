
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} is: {factorial}");
    }

    static long CalculateFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
