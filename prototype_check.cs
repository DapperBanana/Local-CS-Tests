
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);

        Console.WriteLine($"The greatest common divisor of {num1} and {num2} is: {gcd}");
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
