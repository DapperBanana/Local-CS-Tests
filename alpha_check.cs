
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8 }; // Input array of numbers

        int lcm = CalculateLCM(numbers);

        Console.WriteLine("The LCM of the numbers is: " + lcm);
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
