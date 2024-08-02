
using System;

class Program
{
    static int Factorial(int num)
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
        Console.Write("Enter a number to calculate its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(number);

        Console.WriteLine($"The factorial of {number} is {result}");
    }
}
