
using System;

namespace LCMCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int lcm = CalculateLCM(num1, num2);

            Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
        }

        static int CalculateLCM(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int lcm = max;

            while (true)
            {
                if (lcm % min == 0 && lcm % max == 0)
                {
                    return lcm;
                }

                lcm += max;
            }
        }
    }
}
