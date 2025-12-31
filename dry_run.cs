using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            long factorial = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
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
        return n * Factorial(n - 1);
    }
}