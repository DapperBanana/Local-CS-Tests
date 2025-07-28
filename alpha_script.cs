
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int lcm = FindLCM(num1, num2);

        Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
    }

    static int FindLCM(int num1, int num2)
    {
        int max = Math.Max(num1, num2);
        int lcm = max;

        while (true)
        {
            if (lcm % num1 == 0 && lcm % num2 == 0)
            {
                break;
            }
            lcm += max;
        }

        return lcm;
    }
}
