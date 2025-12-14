using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);
        Console.WriteLine($"The GCD of {num1} and {num2} is {gcd}");
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}