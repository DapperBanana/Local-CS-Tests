
using System;

namespace GCDCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = CalculateGCD(num1, num2);

            Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, gcd);
        }

        static int CalculateGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
    }
}
