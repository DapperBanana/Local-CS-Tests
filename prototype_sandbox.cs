
using System;

class Program
{
    static void Main()
    {
        // Get input from user
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Calculate LCM
        int max = (num1 > num2) ? num1 : num2;
        int lcm = max;

        while (true)
        {
            if (lcm % num1 == 0 && lcm % num2 == 0)
            {
                Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
                break;
            }
            lcm += max;
        }
    }
}
