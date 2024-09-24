
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(num);
        Console.WriteLine($"The factorial of {num} is {factorial}");
    }

    static long CalculateFactorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
