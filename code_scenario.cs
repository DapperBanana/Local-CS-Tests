
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }

    static long CalculateFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * CalculateFactorial(number - 1); // Recursive call
        }
    }
}
