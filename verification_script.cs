
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers to calculate their GCD:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);

        Console.WriteLine("The GCD of {0} and {1} is: {2}", num1, num2, gcd);
    }

    static int CalculateGCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return CalculateGCD(b, a % b);
        }
    }
}
