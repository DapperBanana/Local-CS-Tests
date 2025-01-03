
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers to find the LCM:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int lcm = CalculateLCM(num1, num2);

        Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
    }

    static int CalculateLCM(int num1, int num2)
    {
        int max = Math.Max(num1, num2);
        int min = Math.Min(num1, num2);
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
