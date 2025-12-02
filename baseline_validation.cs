using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a non-negative integer:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}