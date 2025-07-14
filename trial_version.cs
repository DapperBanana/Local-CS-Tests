
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8, 10 };

        Console.WriteLine("LCM of the numbers {0} is: {1}", string.Join(", ", numbers), CalculateLCM(numbers));
    }

    static int CalculateLCM(int[] numbers)
    {
        int lcm = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            lcm = CalculateLCM(lcm, numbers[i]);
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
