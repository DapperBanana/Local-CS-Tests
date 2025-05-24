
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int lcm = FindLCM(num1, num2);

        Console.WriteLine("LCM of {0} and {1} is: {2}", num1, num2, lcm);
    }

    static int FindLCM(int a, int b)
    {
        int max = Math.Max(a, b);
        int min = Math.Min(a, b);
        int lcm = max;

        while (true)
        {
            if (lcm % min == 0)
            {
                return lcm;
            }
            lcm += max;
        }
    }
}
