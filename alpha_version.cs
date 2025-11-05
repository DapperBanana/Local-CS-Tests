
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(num);

        Console.WriteLine($"Factorial of {num} is {factorial}");
    }

    static long CalculateFactorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * CalculateFactorial(num - 1);
        }
    }
}
