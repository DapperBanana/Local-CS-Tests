
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers to find their Greatest Common Divisor (GCD):");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = GCD(num1, num2);

        Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}
