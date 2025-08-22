
using System;

class Program
{
    static int Factorial(int n)
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

    static void Main()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        int result = Factorial(number);

        Console.WriteLine($"Factorial of {number} is {result}");
    }
}
