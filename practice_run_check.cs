
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find its factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(num);

        Console.WriteLine($"The factorial of {num} is: {factorial}");
    }

    static long CalculateFactorial(int num)
    {
        if(num == 0)
        {
            return 1;
        }
        
        long result = 1;
        for(int i = 1; i <= num; i++)
        {
            result *= i;
        }

        return result;
    }
}
