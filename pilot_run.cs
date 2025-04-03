
using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);
        Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", num1, num2, gcd);
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
