
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8, 10 };

        int lcm = CalculateLCM(numbers);

        Console.WriteLine("The LCM of the numbers is: " + lcm);
    }

    static int CalculateLCM(int[] numbers)
    {
        int lcm = numbers[0];

        foreach (int number in numbers)
        {
            lcm = CalculateLCM(lcm, number);
        }

        return lcm;
    }

    static int CalculateLCM(int a, int b)
    {
        return a * b / CalculateGCD(a, b);
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
