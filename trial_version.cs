
using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int lcm = FindLCM(num1, num2);

        Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
    }

    static int FindLCM(int num1, int num2)
    {
        int max = Math.Max(num1, num2);
        int min = Math.Min(num1, num2);
        int lcm = max;

        while (true)
        {
            if (lcm % min == 0 && lcm % max == 0)
                break;

            lcm++;
        }

        return lcm;
    }
}
