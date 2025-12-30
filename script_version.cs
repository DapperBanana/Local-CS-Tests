using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
        {
            long result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }

    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}