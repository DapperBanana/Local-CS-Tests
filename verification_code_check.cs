
using System;

class Program
{
    static long Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long result = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {result}");
    }
}
