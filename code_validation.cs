
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

        Console.ReadLine();
    }

    static int FindLCM(int num1, int num2)
    {
        int max = Math.Max(num1, num2);

        while (true)
        {
            if (max % num1 == 0 && max % num2 == 0)
            {
                return max;
            }
            max++;
        }
    }
}
