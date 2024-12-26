
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int lcm = GetLCM(num1, num2);

        Console.WriteLine($"The LCM of {num1} and {num2} is {lcm}");
    }

    static int GetLCM(int num1, int num2)
    {
        int greater = Math.Max(num1, num2);
        int lcm = greater;

        while (true)
        {
            if (lcm % num1 == 0 && lcm % num2 == 0)
            {
                return lcm;
            }
            lcm += greater;
        }
    }
}
