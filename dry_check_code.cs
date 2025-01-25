
using System;

class Program
{
    static int CalculateGCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return CalculateGCD(b, a % b);
    }

    static void Main()
    {
        Console.WriteLine("Enter two numbers to calculate their GCD:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);

        Console.WriteLine($"The greatest common divisor of {num1} and {num2} is {gcd}");
    }
}
